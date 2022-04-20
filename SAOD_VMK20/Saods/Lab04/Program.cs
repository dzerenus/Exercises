int[] coins = new int[] {1, 2, 5, 10};
int sum = 99;

void Main()
{
    int[] count = new int[coins.Length];
    var lsum = sum;

    for (int i = 1; i <= coins.Length; i++)
    {
        if (lsum >= coins[^i])
        {
            count[^i] = lsum / coins[^i];
            lsum %= coins[^i];
        }
    }

    PrintResult(lsum == 0, count);
}

void PrintResult(bool isSuccess, int[] count)
{
    if (!isSuccess)
    {
        Console.WriteLine("Размен НЕ возможен.");
        return;
    }

    Console.WriteLine("Размен возможен.");

    Console.WriteLine($"Сумма для размена: {sum}.");

    Console.Write("Набор монет: ");
    foreach (int i in coins) Console.Write($"{i} ");
    Console.WriteLine();

    for (int i = 0; i < coins.Length; i++)
        Console.WriteLine($"Номинал: {coins[i]} = {count[i]}");
}

Main();