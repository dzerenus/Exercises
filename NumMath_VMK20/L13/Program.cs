namespace L13;

public class Program
{
    // Набор известных значений.
    static (double x, double y)[] data = new (double x, double y)[] {
        (-1.7, 7.88613),
        (-0.7, -3.73737),
        (0.6, 14.37696),
        (1, 24),
        (2, 24),
        (3.2, 2.79552),
    };

    // X, для которого найти Y.
    static double x = 0;

    // i = 0.5

    public static void Main()
    {
        Console.WriteLine(Algs.Lagrange(data, x));
        Console.WriteLine(Algs.Newton(data, x));
    }
}

