namespace L11;

static class Program
{
    static void Main()
    {
        Console.WriteLine("Лабораторная работа №11 - Вариант №8");

        Console.WriteLine("\nЗадание №1");
        Console.WriteLine("7x + 5^x - 2 = 0");

        var nf1 = new NFunction(
            delegate (double x) { return 7*x + Math.Pow(5,x) - 2; },                   // Функция.
            delegate (double x) { return Math.Pow(5,x) * Math.Log(5) + 7; },           // Первая производная.
            delegate (double x) { return Math.Pow(5, x) * Math.Pow(Math.Log(5), 2); }  // Вторая производная.
            );

        Console.WriteLine($"Найденные границы: {nf1.Borders.A}:{nf1.Borders.B}");
        Console.WriteLine($"Поиск по касательным: {nf1.RootByCTangents()}");
        Console.WriteLine($"Поиск половинным делением: {nf1.RootByHalfs()}");


        Console.WriteLine("\nЗадание №2");
        Console.WriteLine("-x^3 - 3x^2 - 5x + 4 = 0");

        var nf2 = new NFunction(
            delegate (double x) { return -Math.Pow(x, 3) - 3 * Math.Pow(x, 2) - 5 * x + 4; }, // Функция.
            delegate (double x) { return -3*Math.Pow(x, 2) - 6*x - 5; },                      // Первая производная.
            delegate (double x) { return -6*x-6; }                                            // Вторая производная.
            );

        Console.WriteLine($"Найденные границы: {nf2.Borders.A}:{nf2.Borders.B}");
        Console.WriteLine($"Поиск по касательным: {nf2.RootByCTangents()}");
        Console.WriteLine($"Поиск половинным делением: {nf2.RootByHalfs()}");
    }
}
