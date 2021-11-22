using System;
using System.Collections.Generic;
using System.Text;

namespace Program01
{
    class Rectangle
    {
        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public double Width { get => width; set => width = value; }
        public double Height { get => height; set => height = value; }

        double x, y, width, height;

        public Rectangle(double x, double y, double width, double height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public double Square() => width * height;

        // Переопределение оператора умножения.

        public static Rectangle operator *(Rectangle a, double n)
            => new Rectangle(a.x, a.y, a.width * n, a.height * n);

        public static Rectangle operator *(double n, Rectangle a)
            => a * n;

        // Переопределение операторов сравнения.

        public static bool operator ==(Rectangle a, Rectangle b)
            => a.Square() == b.Square();

        public static bool operator !=(Rectangle a, Rectangle b)
            => !(a == b);

        public static bool operator >(Rectangle a, Rectangle b)
            => a.Square() > b.Square();

        public static bool operator >=(Rectangle a, Rectangle b)
            => a.Square() >= b.Square();

        public static bool operator <(Rectangle a, Rectangle b)
            => !(a >= b);

        public static bool operator <=(Rectangle a, Rectangle b)
            => !(a > b);

        // Переопределение ToString().

        public override string ToString()
            => $"[X:{x} Y:{y} W:{width} H:{height} SQR:{Square()}]";

        // Переопределние всякой ерунды.

        public override bool Equals(object obj)
            => base.Equals(obj);

        public override int GetHashCode()
            => base.GetHashCode();
    }
}
