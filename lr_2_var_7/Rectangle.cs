using System;
using System.Collections.Generic;
using System.Text;

namespace lr_2_var_7
{
    class Rectangle : Figure
    {
        private Point a;
        private Point b;
        private Point c;
        private Point d;

        public Rectangle(Point a, Point d)
        {
            this.a = a;
            this.d = d;
            b = new Point(d.x, a.y);
            c = new Point(a.x, d.y);
        }


        public override double GetPerimeter()
        {
            return (GetLength(a, b) + GetLength(a, d)) * 2;
        }
        public override double GetSquare()
        {
            return GetLength(a, b) * GetLength(a, d);
        }
    }
}
