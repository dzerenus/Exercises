using System;

namespace L04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Получаем размер матрицы.
            Console.Write("  Size: ");
            var rank = int.Parse(Console.ReadLine());

            // Создаём матрицу и выводим результат.
            var mat = new TDMatrix(rank);
            mat.PrintResult();
        }
    }
}
