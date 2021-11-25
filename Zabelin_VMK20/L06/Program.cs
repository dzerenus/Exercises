using System;

namespace L06
{
    class Program
    {
        // Входные данные.
        static double[,] iData = new double[,]
        {
            { 38, 6, 9, -2, -6, 45 },
            { -4, 36, -4, -6, 7, 58 },
            { -1, 1, 6, -1, 0, 15 },
            { 6, -4, 7, 23, -2, 60 },
            { -5, 7, -3, 8, 26, 33 }
        };

        static void Main(string[] args)
        {
            // Массивы для переменных X.
            double[] xOne = new double[iData.GetLength(0)];
            double[] xTwo = new double[iData.GetLength(0)];

            double epsilon = 0.001; // Допускаемая точность.

            while (true)
            {
                for (int i = 0; i < iData.GetLength(0); i++)
                {
                    double sum = 0;
                    for (int j = 0; j < iData.GetLength(1) - 1; j++)
                        if (i != j) 
                            sum += xOne[j] * iData[i, j];

                    xTwo[i] = (iData[i, iData.GetLength(1) - 1] - sum) / iData[i, i];
                }

                int c = 0;
                for (int i = 0; i < iData.GetLength(0); i++)
                    if (xTwo[i] - xOne[i] < epsilon) c += 1;

                if (c == iData.GetLength(0)) break;
                else 
                    for (int i = 0; i < iData.GetLength(0); i++)
                        xOne[i] = xTwo[i];
            }

            Console.WriteLine("Решение: ");
            for (int i = 0; i < xTwo.Length; i++)
                Console.WriteLine($"X{i + 1}: {xTwo[i]}");
        }
    }
}
