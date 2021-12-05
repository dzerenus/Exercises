using System;

namespace L04
{
    /// <summary>
    /// Трёхдиагональная матрица.
    /// </summary>
    class TDMatrix
    {
        int size;                           // Размерность матрицы
        double[,] mat;                      // Матрица.
        double[] a, b, c, alfa, beta, x, f; // Вспомогательные массивы.

        /// <summary>
        /// Трёхдиагональная матрица задаётся размерностью её размерностью.
        /// Матрица заполняется случайными числами.
        /// </summary>
        /// <param name="rank">Размерность матрицы.</param>
        public TDMatrix(int rank)
        {
            // Сохраняем размерность матрицы.
            size = rank; 

            // Определяем все объявленные массивы.
            mat = new double[rank, rank]; // Матрица.
            a = new double[rank];         // Коэффициенты A.
            b = new double[rank];         // Коэффициенты B.
            c = new double[rank];         // Коэффициенты C.
            alfa = new double[rank];      // Массив под Alpha-числа.
            beta = new double[rank];      // Массив под Beta-числа.
            x = new double[rank];         // Массив под овтеты.
            f = new double[rank];         // Правая часть матрицы.

            Random rnd = new Random();

            for (int i = 0; i < rank; i++)
            {
                // Заполнение диагоналей матрицы случайными числами.
                // Заполнение массивов коэффициентов этими же числами.
                if (i > 0) a[i] = mat[i, i - 1] = rnd.Next(-9, 9);
                if (i < rank - 1) b[i] = mat[i, i + 1] = rnd.Next(-9, 9);
                c[i] = mat[i, i] = rnd.Next(-9, 9);

                f[i] = rnd.Next(-9, 9);

                // Рассчёт alpha и beta, начиная со второй итерации.
                if (i > 0)
                {
                    int p = i - 1;
                    alfa[i] = -b[p] / (c[p] + a[p] * alfa[p]);
                    beta[i] = (f[p] - a[p] * beta[p]) / (c[p] + a[p] * alfa[p]);
                }
            }

            // Рассчёт последнего X по последней строке матрицы.
            int r = rank - 1;
            x[r] = (f[r] - a[r] * beta[r]) / (c[r] + a[r] * alfa[r]);

            // Рассчёт остальных значений X.
            for (int i = r - 1; i >= 0; i--)
                x[i] = x[i + 1] * alfa[i + 1] + beta[i + 1];
        }

        /// <summary>
        /// Процедура вывода всей информации о матрице и её решения на экран.
        /// </summary>
        public void Print() 
        {
            // Вывод самой матрицы.
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++) PrintNum(mat[i, j]);
                Console.Write("  |");
                PrintNum(f[i]);
                Console.WriteLine();
            }

            // Вывод A-коэффициентов.
            Console.WriteLine();
            Console.Write("  a:");
            for (int i = 0; i < size; i++) PrintNum(a[i]);

            // Вывод C-коэффициентов.
            Console.WriteLine();
            Console.Write("  c:");
            for (int i = 0; i < size; i++) PrintNum(c[i]);

            // Вывод B-коэффициентов.
            Console.WriteLine();
            Console.Write("  b:");
            for (int i = 0; i < size; i++) PrintNum(b[i]);

            // Вывод alpha чисел.
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("  alfa:");
            for (int i = 0; i < size; i++) PrintNum(alfa[i]);

            // Вывод beta чисел.
            Console.WriteLine();
            Console.Write("  beta:");
            for (int i = 0; i < size; i++) PrintNum(beta[i]);

            // Вывод решений на экран.
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("  x:");
            for (int i = 0; i < size; i++) PrintNum(x[i]);
            Console.WriteLine();
        }

        /// <summary>
        /// Вывод каждого числа в зависимости от его знака в виде сетки.
        /// </summary>
        void PrintNum(double num)
        {
            if (num < 0) Console.Write(" ");
            else Console.Write("  ");
            Console.Write(num.ToString("0.00"));
        }
    }
}
