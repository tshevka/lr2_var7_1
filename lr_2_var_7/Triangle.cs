using System;
using System.Collections.Generic;
using System.Text;

namespace lr_2_var_7
{
    class Triangle : Figure
    {
        private Point x;
        private Point y;
        private Point z;

        public Triangle(Point x, Point y, Point z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override double GetSquare()
        {
            double perimeter = GetPerimeter() / 2;

            return Math.Sqrt(perimeter * (perimeter - GetLength(x, y)) * (perimeter - GetLength(y, z)) * (perimeter - GetLength(x, z)));
        }

        public override double GetPerimeter()
        {
            return GetLength(x, y) + GetLength(y, z) + GetLength(x, z);
        }
    }
}
