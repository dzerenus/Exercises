using Lab06;

namespace Lab06
{
    public static class Program
    {
        delegate int Alg(int[] arr, int val);


        public static void Main()
        {
            Alg Linear = Finds.Linear(a, 9);
            Alg Binary = Finds.Binary(a)

            var a = new int[] { 5, 4, 3, 9, 7, 2 };
            Console.WriteLine(Finds.Linear(a, 9));
            Console.WriteLine(Finds.Binary(a, 9));
        }
    }
}

