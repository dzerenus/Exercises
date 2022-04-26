using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace DataStealer;

internal class Program
{
    // Имя файла, куда сохраняется результат.
    public static readonly string FileName = "result.txt";

    static void Main()
    {
        Console.WriteLine("Поочередно введите ссылки, которые вы хотите проверить.");
        Console.WriteLine("Когда ввод ссылок будет окончен, введите пустую строку.");

        // Ввод данных.
        // Ввод продолжается до тех пор, пока не будет введена пустая строка.
        var links = new List<string>();
        while (true)
        {
            Console.Write("Ссылка: ");
            var link = Console.ReadLine();
            if (link == null || link == "") break;
            links.Add(link);
        }

        Console.WriteLine("Ввод окончен, производим парсинг.");

        // Асихронно отправляем запросы по всем полученным ссылкам.
        var tasks = new Task<Paint>?[links.Count];
        for (int i = 0; i < links.Count; i++)
            tasks[i] = ParseData(links[i]);

        // Ожидаем, пока все ссылки не будут обработаны программой.
        int completeCount = -1;
        while (completeCount < links.Count)
        {
            int c = 0;
            foreach (var t in tasks) if (t == null || t.IsCompleted) c++;

            if (c != completeCount)
            {
                completeCount = c;
                Console.WriteLine($"Товаров получено: {c}/{tasks.Length}");
            }

            Thread.Sleep(100);
        }

        // Сохраняем данные результата в файл.
        Console.WriteLine("Сохранение данных...");
        var paints = new Paint?[links.Count];
        for (int i = 0; i < links.Count; i++)
            paints[i] = tasks[i] == null ? null : tasks[i].Result;
        ToFile(FileName, paints);

        Console.WriteLine($"Данные сохранены в {FileName}!");
        Console.WriteLine("Нажмите любую клавишу!");
        Console.ReadKey();
    }

    /// <summary>
    /// Асинхронный парсинг товара по ссылке.
    /// </summary>
    /// <param name="link">Ссылка</param>
    /// <returns>Экземляр объкта краски.</returns>
    static async Task<Paint> ParseData(string link)
    {
        var p = new Paint() { URL = link };

        var id = link.Split('/')[^1];
        var reqUrl = $"https://www.devoordeelmarkt.nl/api/aspos/products/url/{id}?refresh=false";
        var js = await GetJson(reqUrl);
        FillPaintClass(p, js);

        return p;
    }

    /// <summary>
    /// Сохранение массива объектов класса краски в файл.
    /// </summary>
    /// <param name="filename">Имя файла.</param>
    /// <param name="paints">Массив объектов красок.</param>
    static void ToFile(string filename, in Paint?[] paints)
    {
        var isCreated = File.Exists(filename);

        using var sw = new StreamWriter(filename, true);
        string format = "{0,-20}{1,-40}{2,-40}{3,-40}{4,-20}{5,-20}{6,-20}{7}";

        // Если файл не сущестововал до выполнения функция, записываем в файле заголовок.
        if (!isCreated)
            sw.WriteLine(string.Format(format, "Brand", "Title", "Color", "Volume", "Current Price", "Recommended price", "EAN", "URL"));

        foreach (var p in paints)
        {
            if (p == null) continue;
            var row = string.Format(format, p.Brand, p.Title, p.Color, p.Volume, p.PriceCur, p.PriceRec, p.EAN, p.URL);
            sw.WriteLine(row);
        }
    }

    /// <summary>
    /// Выполнение GET запроса и получение объектов парсинга.
    /// </summary>
    /// <param name="url">Ссылка запроса.</param>
    /// <returns>Экземпляр JSON объекта файла.</returns>
    static async Task<JObjects.JSONModel?> GetJson(string url)
    {
        using var client = new HttpClient();
        using var respon = await client.GetAsync(url);

        var resstr = await respon.Content.ReadAsStringAsync();

        return JsonConvert.DeserializeObject<JObjects.JSONModel>(resstr);
    }

    /// <summary>
    /// Вычленение информации о краски из JSON объекта.
    /// </summary>
    /// <param name="p">Краска.</param>
    /// <param name="js">JSON объект.</param>
    static void FillPaintClass(in Paint p, in JObjects.JSONModel? js)
    {
        if (js == null || !js.Success || js.Product == null) return;

        if (js.Product.Brand != null) p.Brand = js.Product.Brand.Description;
        if (js.Product.DefaultScanCode != null) p.EAN = js.Product.DefaultScanCode.Code;
        p.Title = js.Product.OnlineDescription;
        p.PriceCur = js.Product.PriceInclTax;

        // Данные о рекомендуемой цене занесены в отдельный блок JSON, откуда их можно вытащить только перебором.
        if (js.Product.Fields != null)
            foreach (var field in js.Product.Fields)
                if (field.Code == "Adviesprijs")
                {
                    p.PriceRec = field.Value;
                    break;
                }

        // Данные о цене и объеме товара можно получить из таблицы, которая идёт вместе в данных о товаре.
        if (js.Product.Memos != null)
            foreach (var memo in js.Product.Memos)
                if (memo.MemoType == "InternetMemo")
                {
                    string text = memo.Text ?? "";
                    text = text.Replace("\n", "");
                    text = text.Replace("\r", "");

                    while (text.Contains("  "))
                        text = text.Replace("  ", " ");

                    text = text.Replace("<td> ", "<td>");
                    text = text.Replace(" <td>", "<td>");
                    text = text.Replace(" </td>", "</td>");
                    text = text.Replace("</td> ", "</td>");

                    var c = Regex.Match(text, "<td>Kleur:</td><td>(.*?)</td>");
                    if (c.Success)
                    {
                        var color = c.Value.Replace("<td>Kleur:</td><td>", "");
                        color = color.Replace("</td>", "");
                        p.Color = color;
                    }

                    var v = Regex.Match(text, "<td>Inhoud:</td><td>(.*?)</td>");
                    if (v.Success)
                    {
                        var volume = v.Value.Replace("<td>Inhoud:</td><td>", "");
                        volume = volume.Replace("</td>", "");
                        p.Volume = volume;
                    }

                    break;
                }
    }
}