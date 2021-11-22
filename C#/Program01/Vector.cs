using System;
using System.Collections.Generic;
using System.Text;

namespace Program01
{
    public class Vector
    {
        readonly double x, y;

        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        // Переопределение оператора сложения.
        // Теперь сложение двух векторов вернёт новый третий вектор.
        public static Vector operator +(Vector v1, Vector v2) 
            => new Vector(v1.x + v2.x, v1.y + v2.y);

        // Переопредение оператора умножения.
        // Теперь умножение двух векторов вернёт их скалярное произведение.
        public static double operator *(Vector v1, Vector v2) 
            => v1.x * v2.x + v1.y * v2.y;

        // Перегрузка оператора умножения.
        // Теперь умножение вектора на число вернёт новый вектор.
        public static Vector operator *(Vector v1, double n) 
            => new Vector(v1.x * n, v1.y * n);

        // Перегрузка оператора умножения.
        // Умножение метода на число с изменением очередности множителей.
        public static Vector operator *(double n, Vector v1)
            => v1 * n;

        public static Vector operator -(Vector v1)
            => v1 * -1;

        // Переопределение ToString().
        // Теперь она выводит координаты вектора.
        public override string ToString()
        {
            return $"[{x} {y}]";
        }
    }
}
