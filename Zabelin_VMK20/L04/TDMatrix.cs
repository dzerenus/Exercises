using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04
{
    /// <summary>
    /// Трёхдиагональная матрица.
    /// </summary>
    class TDMatrix
    {
        int size;
        double[,] mat;
        double[] a, b, c, alfa, beta, x, f;

        public TDMatrix(int rank)
        {
            size = rank;

            mat = new double[rank, rank];
            a = new double[rank];
            b = new double[rank];
            c = new double[rank];
            alfa = new double[rank];
            beta = new double[rank];
            x = new double[rank];
            f = new double[rank];

            Random rnd = new Random();

            for (int i = 0; i < rank; i++)
            {
                if (i > 0) a[i] = mat[i, i - 1] = rnd.Next(-9, 9);
                if (i < rank - 1) b[i] = mat[i, i + 1] = rnd.Next(-9, 9);
                c[i] = mat[i, i] = rnd.Next(-9, 9);

                f[i] = rnd.Next(-9, 9);

                if (i > 0)
                {
                    int p = i - 1;
                    alfa[i] = -b[p] / (c[p] + a[p] * alfa[p]);
                    beta[i] = (f[p] - a[p] * beta[p]) / (c[p] + a[p] * alfa[p]);
                }
            }

            int r = rank - 1;
            x[r] = (f[r] - a[r] * beta[r]) / (c[r] + a[r] * alfa[r]);

            for (int i = r - 1; i >= 0; i--)
                x[i] = x[i + 1] * alfa[i + 1] + beta[i + 1];
        }

        public void PrintResult()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++) PrintNum(mat[i, j]);
                Console.Write("  |");
                PrintNum(f[i]);
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.Write("  a:");
            for (int i = 0; i < size; i++) PrintNum(a[i]);

            Console.WriteLine();
            Console.Write("  c:");
            for (int i = 0; i < size; i++) PrintNum(c[i]);

            Console.WriteLine();
            Console.Write("  b:");
            for (int i = 0; i < size; i++) PrintNum(b[i]);

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("  alfa:");
            for (int i = 0; i < size; i++) PrintNum(alfa[i]);

            Console.WriteLine();
            Console.Write("  beta:");
            for (int i = 0; i < size; i++) PrintNum(beta[i]);

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("  x:");
            for (int i = 0; i < size; i++) PrintNum(x[i]);
            Console.WriteLine();
        }

        void PrintNum(double num)
        {
            if (num < 0) Console.Write(" ");
            else Console.Write("  ");
            Console.Write(num.ToString("0.00"));
        }
    }
}
