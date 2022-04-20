using System;

namespace Lab14;

// by ShpriZZ in 2022

internal class Program
{
    delegate double Func(double val);  // Делегат интегрируемой функции.

    static void Main()
    {
        Console.WriteLine("ВМК-20: Шарин — Вариант 8 — Лаб №14\n");

        // Делегат по формуле трапеций.
        Console.WriteLine("Задание A: Вычислить интеграл по формуле трапеций.");
        Console.WriteLine("> Функция: F(x) = 1 / sqrt(2*x^2 + 2)");
        Console.WriteLine("> Ниж. предел: 0.6");
        Console.WriteLine("> Вер. предел: 1.4");
        Console.WriteLine("> Результат: " + TrapecoidIntegral(x => 1 / Math.Sqrt(2 * Math.Pow(x, 2) + 2), 0.6, 1.4, 500000) + '\n');

        // Делегат по формуле Симпсона.
        Console.WriteLine("Задание B: Вычислить интеграл по формуле Симпсона.");
        Console.WriteLine("> Функция: F(x) = sin(x^2 + 1) / (x^2 + 1)");
        Console.WriteLine("> Ниж. предел: 0.4");
        Console.WriteLine("> Вер. предел: 1.2");
        Console.WriteLine("> Результат: " + SimpsonIntegral(x => Math.Sin(Math.Pow(x, 2) + 1) / (Math.Pow(x, 2) + 1), 0.4, 1.2, 250000) + '\n');
    }

    /// <summary>
    /// Вычисление интеграла по формуле трапеций.
    /// </summary>
    /// <param name="f">Интегрируемая функция.</param>
    /// <param name="a">Нижняя граница интегрирования.</param>
    /// <param name="b">Верхняя граница интегрирования.</param>
    /// <param name="n">Количество участков.</param>
    static double TrapecoidIntegral(Func f, double a, double b, int n)
    {
        double h = (b - a) / n;
        double w = 0;

        for (int k = 1; k < n - 1; k++)
            w += f(a + k * h);

        return (2 * w + f(a) + f(b)) * h / 2;
    }

    /// <summary>
    /// Вычисление интеграла по формуле параболических трапеций (Симпсона).
    /// </summary>
    /// <param name="f">Интегрируемая функция.</param>
    /// <param name="a">Нижняя граница интегрирования.</param>
    /// <param name="b">Верхняя граница интегрирования.</param>
    /// <param name="m">Количество пар отрезков.</param>
    /// <returns>Приблизительное значение интеграла.</returns>
    static double SimpsonIntegral(Func f, double a, double b, int m)
    {
        int n = 2 * m;
        double h = (b - a) / n;

        double s1 = 0;
        double s2 = 0;

        for (int k = 1; k < m; k++)
            s1 += f(a + (2 * k - 1) * h);

        for (int k = 1; k < m - 1; k++)
            s2 += f(a + 2 * k * h);

        return (4 * s1 + 2 * s2 + f(a) + f(b)) * h / 3;
    }
}
