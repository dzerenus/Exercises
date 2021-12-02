namespace L04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Получаем размер матрицы.
            System.Console.Write("  Size: ");
            var rank = int.Parse(System.Console.ReadLine());

            // Создаём матрицу и выводим результат.
            var mat = new TDMatrix(rank);
            mat.Print();
        }
    }
}
