using System;

namespace Program01
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Rectangle(0, 0, 5, 5);
            var b = new Rectangle(4, 4, 10, 10);

            var c = a * 2;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.WriteLine(a > b);
            Console.WriteLine(b > a);

            Console.WriteLine(c == b);

        }
    }
}
