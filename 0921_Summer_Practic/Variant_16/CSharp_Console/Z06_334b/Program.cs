using System;

namespace Z06_334b
{
    class Program
    {
        static void Main(string[] args)
        {   
            double result = 0;

            for (int i = 1; i <= 100; i++)
                for (int j = 1; j <= 100; j++)
                    result += Math.Sin(Math.Pow(i, 3) + Math.Pow(j, 4));

            Console.WriteLine(result);
        }
    }
}
