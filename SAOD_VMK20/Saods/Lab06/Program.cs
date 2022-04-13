using System.Diagnostics;

namespace Lab06
{
    public static class Program
    {
        static readonly int FindInt = 9;

        public static void Main()
        {
            // Массив для демонстрации работы.
            var a = new int[] { 5, 4, 3, 9, 7, 2, 5, 6, 7, 12, 4, 32, 56, 22 };


            Console.WriteLine($"Значение для поиска: {FindInt}\n");  // Значение поиска.

            Console.WriteLine("Массив: ");
            PrintArray(a);                                         // Вывод массива.

            int Linear = Finds.Linear(a, FindInt);                 // Линейный поиск.
            Console.WriteLine("Линейный поиск: " + Linear + '\n'); // Вывод результата.

            Console.WriteLine("Сортированный массив: ");
            Array.Sort(a);                                   // Сортируем массив средставми языка.
            PrintArray(a);                                   // Выводим осортированный массив.
            int Binary = Finds.Binary(a, FindInt);           // Бинарный поиск.
            Console.WriteLine("Бинарный поиск: " + Binary);  // Вывод результата.

            GetTime();
        }

        static void PrintArray(int[] a)
        {
            foreach (var i in a)
                Console.Write($"{i} ");
            Console.WriteLine();
        }

        static void GetTime()
        {
            var rnd = new Random();

            var ar = new int[5000];
            for (int i = 0; i < ar.Length; i++)
                ar[i] = rnd.Next(100000);

            int fValue = ar[4990];

            var sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 200000; i++)
                Finds.Linear(ar, fValue);
            sw.Stop();

            Console.WriteLine((double)sw.ElapsedMilliseconds / 200000);

            sw.Start();
            for (int i = 0; i < 200000; i++)
            {
                Array.Sort(ar);
                Finds.Binary(ar, fValue);
            }
            sw.Stop();
            Console.WriteLine((double)sw.ElapsedMilliseconds / 200000);

        }
    }
}

