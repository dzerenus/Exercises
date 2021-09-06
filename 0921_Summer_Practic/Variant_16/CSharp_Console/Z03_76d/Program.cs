using System;

namespace Z03_76d
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("> Фигура — Ферзь");

            // Ввод начальных данных.
            Console.Write("Введите высоту поля: ");
            int height = Int32.Parse(Console.ReadLine());
            
            Console.Write("Введите ширину поля: ");
            int width = Int32.Parse(Console.ReadLine());

            Console.Write("Введите X фигуры (K): ");
            int xf = Int32.Parse(Console.ReadLine());

            Console.Write("Введите Y фигуры (L): ");
            int yf = Int32.Parse(Console.ReadLine());

            Console.Write("Введите X цели (M): ");
            int xt = Int32.Parse(Console.ReadLine());

            Console.Write("Введите Y цели (N): ");
            int yt = Int32.Parse(Console.ReadLine());

            // Проверка правильности ввода.
            if (xf >= width || yf >= height || xt >= width || yt >= height
                || xf < 0 || yf < 0 || xt < 0|| yt < 0) 
            {
                Console.WriteLine("ОШИБКА! Координаты заданы неверно!");
                return;
            }

            // Может ли попасть за один ход.
            if (xf == xt || yf == yt || xf == yt || yf == xt)
                Console.WriteLine("Можно попасть в цель за один ход!");

            // Рассчёт двух ходов.
            else
            {
                int hor = xf - xt;
                int ver = yf - yt;

                Console.WriteLine("Можно попасть только за два хода!");
                Console.WriteLine($"Первый ход - сдвинуться по X на {hor} клеток.");
                Console.WriteLine($"Второй ход - сдвинуться по Y на {ver} клеток.");
            }
        }
    }
}
