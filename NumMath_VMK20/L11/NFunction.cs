
namespace L11;

public class NFunction
{
    // Точность вычисления.
    public readonly static double EPSILLON = 0.001;

    public delegate double F(double x); // Делегирующая функция.
    public readonly F Function;         // Делегат функции.
    public readonly F DFunction;        // Делегат первой производной.
    public readonly F DDFunction;       // Делегат второй производной.

    public readonly (double A, double B) Borders; // Примерные границы корня функции.

    /// <summary>
    /// Функция поиска корня функции двумя методами.
    /// </summary>
    /// <param name="Func">Делегат функции.</param>
    /// <param name="DFunc">Делегат первой производной.</param>
    /// <param name="DDFunc">Делегат второй производной.</param>
    public NFunction(F Func, F DFunc, F DDFunc)
    {
        // Назначаем переменные.
        Function = Func;
        DFunction = DFunc;
        DDFunction = DDFunc;

        // Ищем примерные границы функции.
        Borders = FindBorders(-100, 100, 0.5);
    }

    /// <summary>
    /// Поиск корня методом хорд и касательных.
    /// </summary>
    /// <returns>Корень функции./returns>
    /// <exception cref="Exception"></exception>
    public double RootByCTangents()
    {
        // Границы.
        double a = Borders.A;
        double b = Borders.B;

        // Цикл работает, пока точность недостаточна.
        while (b - a > 2 * EPSILLON)
        {
            double c = (a * Function(b) - b * Function(a)) / (Function(b) - Function(a));

            if (Function(a) * DDFunction(a) > 0)
            {
                a -= Function(a) / DFunction(a);
                b = c;
            }

            else if (Function(b) * DDFunction(b) > 0)
            {
                a = c;
                b -= Function(b) / DFunction(b);
            }

            // Чтобы избежать зацикливания установим исключения. На всякий случай.
            else throw new Exception("CYCLE ERROR");
        }

        // Возвращаем результат.
        return (a + b) / 2;
    }

    /// <summary>
    /// Получение корня уравнения методом половинного деления.
    /// </summary>
    /// <returns>Корень функции.</returns>
    public double RootByHalfs()
    {
        // Границы.
        double a = Borders.A;
        double b = Borders.B;

        while (b - a > 2 * EPSILLON)
        {
            // Ищем центр отрезка.
            double c = (a + b) / 2;

            // Устанавливаем новые границы.
            if (Function(a) * Function(c) < 0) b = c;
            else if (Function(b) * Function(c) < 0) a = c;
            else return (a + b) / 2;
        }

        // Возвращаем результат.
        return (a + b) / 2;
    }

    /// <summary>
    /// Поиск примерных границ местоположения ОДНОГО корня функции.
    /// </summary>
    /// <param name="low">Минимальная граница поиска.</param>
    /// <param name="max">Максимальная граница поиска.</param>
    /// <param name="step">Шаг поиска.</param>
    /// <returns>Кортеж из двух чисел (X1, X2) между которыми находится корень.</returns>
    /// <exception cref="Exception">Если корень не найден.</exception>
    private (double, double) FindBorders(double low, double max, double step)
    {
        // Ищем границы.
        for (double i = low; i < max; i += step)
        {
            double b = i;
            double a = i - step;

            if (Function(a) * Function(b) < 0) return (a, b);
        }

        // Если не нашли, вызываем исключение.
        throw new Exception("FUNCTION ERROR");
    }
}
