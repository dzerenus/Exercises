using System;

namespace L07
{
    class Program
    {
        // Входная СЛАУ.
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
            // Получаем размерность массива,
            // чтобы не обращаться каждый раз к функции.
            int rows = iData.GetLength(0);
            int cols = iData.GetLength(1);

            // Массивы для переменных X.
            // Массив xTwo объявлен, но не определен, поскольку
            // каждую итерацию необходимо его обнулять.
            var xOne = new double[rows];
            double[] xTwo;

            // Допускаемая точность.
            double epsilon = 0.001;

            while (true)
            {
                // Определение массива xTwo.
                xTwo = new double[rows];

                int k = 0; // Счётчик шагов k.
                for (int i = 0; i < rows; i++)
                {
                    double d1 = 0; // X1(k + 1)
                    double d2 = 0; // X2(k + 1)

                    // Рассчёт X1 при условии, исключения значения с главной диагонали.
                    for (int j = 0; j < k; j++)
                        if (i != j) d2 += xTwo[j] * iData[i, j];

                    // Рассчёт X2 при условии исключения значения с главной диагонали.
                    for (int j = k; j < cols - 1; j++)
                        if (i != j) d1 += xOne[j] * iData[i, j];

                    // Подставляем только что вычисленные значения и увеличиваем счётчик.
                    // При этом d1 и d2 начнут влиять на полученный X только со второго шага.
                    xTwo[i] = (iData[i, cols - 1] - d1 - d2) / iData[i, i];
                    k++;
                }

                // Считаем количество иксов, для которых достигнута требуемая точность.
                int count = 0;
                for (int i = 0; i < rows; i++)
                    if ((xTwo[i] - xOne[i]) < epsilon) count++;

                // Выходим из цикла при достижении необходимой точности для всех строк.
                if (count == rows) break;
                else xOne = xTwo; // Перемещаем элементы из второго массива в первый.
            }

            // Вывод результата.
            Console.WriteLine("Решение:");
            for (int i = 0; i < rows; i++)
                Console.WriteLine($"X{i + 1}: {xTwo[i]}");
        }
    }
}
