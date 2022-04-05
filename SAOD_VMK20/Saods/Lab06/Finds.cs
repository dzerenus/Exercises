namespace Lab06;

public static class Finds
{
    /// <summary>
    /// Линейный поиск.
    /// </summary>
    /// <param name="arr">Массив.</param>
    /// <param name="val">Искомое значение.</param>
    /// <returns>Индекс результата.</returns>
    public static int Linear(int[] arr, int val)
    {
        for (int i = 0; i < arr.Length; i++)
            if (arr[i] == val) return i;

        return -1;
    }

    /// <summary>
    /// Бинарный поиск в массиве.
    /// </summary>
    /// <param name="arr">Массив.</param>
    /// <param name="val">Искомое значение.</param>
    /// <returns>Индекс результата.</returns>
    public static int Binary(int[] arr, int val)
    {
        // Если массив пустой, выходим.
        if (arr.Length == 0) return -1;

        Array.Sort(arr); // Сортируем массив средставми языка.

        // Указываем начальные границы поиска.
        var l = 0;
        var r = arr.Length - 1;

        while (true)
        {
            // Максимально сужаем границы поиска.

            if (r - l == 1)
            {
                if (arr[l] == val) return l; // Если левая граница равна искомому, возвращаем её.
                if (arr[r] == val) return r; // Если правая граница равна искомому, возвращаем её.
                return -1;                   // Выходим, если не нашли.
            } 

            else
            {
                var c = l + (r - l) / 2; // Берем центральное значение.
                if (c == val) return c;  // Если центр равен искомому, возращаем его.
                if (val > c) l = c;      // Если искомое больше середины, двигаем левую границу.
                if (val < c) r = c;      // Если искомое меньше середины, двигаем правую границу.
            }
        }
    }
}
