namespace L13;

public static class Algs
{
    public static double Lagrange((double x, double y)[] data, double x)
    {
        double lagrange = 0;
        for (int i = 0; i < data.Length; i++)
        {
            double c = 1;
            double z = 1;

            for (int j = 0; j < data.Length; j++)
                if (i != j)
                {
                    c *= x - data[i].x;
                    z *= data[i].x - data[j].x;
                }

            lagrange += data[i].y * c / z;
        }

        return lagrange;
    }

    public static double Newton((double x, double y)[] data, double x)
    {
        var newton = data[^1].y;
        double prod = 1;

        for (int k = 1; k < data.Length; k++)
        {
            prod *= x - data[data.Length - k].x;
            newton += data[k].y * prod;
        }

        return newton;
    }
}
