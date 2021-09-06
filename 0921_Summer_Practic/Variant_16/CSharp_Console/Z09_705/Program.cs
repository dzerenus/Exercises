using System;

namespace Z09_705
{
    class Program
    {   
        const int N = 3; // Порядок матрицы.

        static void Main(string[] args)
        {   
            // Создаём матрицы.
            double[,] aMatrix = RandomMatrix(); // Случайная.
            double[,] bMatrix = RandomMatrix(); // Случайная.
            double[,] eMatrix = EMatrix();      // Единичная.   
            double[,] cMatrix = СMatrix();      // С Матрица.

            // Вывод матриц на экран:
            Console.WriteLine("\n> A матрица:");
            PrintMatrix(aMatrix);
            
            Console.WriteLine("\n> B матрица:");
            PrintMatrix(bMatrix);

            Console.WriteLine("\n> E матрица:");
            PrintMatrix(eMatrix);
            
            Console.WriteLine("\n> C матрица:");
            PrintMatrix(cMatrix);

            // Рабочий ход программы.

            // Отнимаем матрицы.
            var r = new double[N,N]; // Результат.
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    r[i,j] = bMatrix[i,j] - eMatrix[i,j];

            // Перемножаем.
            var m = new double[N,N]; // Результат.
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    for (int g = 0; g < N; g++)
                        m[i,j] += (aMatrix[i, g] * r[g, j]);

            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    m[i,j] += cMatrix[i,j];

            Console.WriteLine("\n> Результат:");
            PrintMatrix(m);     

        }

        // Создание случайной матрицы.
        static double[,] RandomMatrix()
        {   
            var rnd = new Random();       // Рандом.
            var matrix = new double[N,N]; // Пустая матрица.

            // Заполнение матрицы случайными числами.
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    matrix[i,j] = rnd.Next(10);

            return matrix; // Возвращение.
        }

        // Создание единичной матрицы.
        static double[,] EMatrix()
        {   
            var matrix = new double[N,N]; // Пустая матрица.

            // Заполнение матрицы единицами.
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    matrix[i,j] = 1;

            return matrix; // Возвращение.
        }

        // Создание единичной матрицы.
        static double[,] СMatrix()
        {
            var matrix = new double[N,N]; // Пустая матрица.

            // Заполнение матрицы рассчётными числами.
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    matrix[i,j] = 1.0/(i+j+2);

            return matrix; // Возвращение.
        }

        static void PrintMatrix(double[,] matrix)
        {
            for (int i = 0; i < N; i++) 
            {
                for (int j = 0; j < N; j++)
                    Console.Write(matrix[i,j].ToString("0.00") + " ");
                Console.Write("\n");
            }
        }
    }
}
