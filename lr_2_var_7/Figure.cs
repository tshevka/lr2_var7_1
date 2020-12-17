using System;
using System.Collections.Generic;
using System.Text;

namespace lr_2_var_7
{
    abstract class Figure
    {
        public abstract double GetSquare();
        public abstract double GetPerimeter();

        protected double GetLength(Point x, Point y)
        {
            return Math.Sqrt(Math.Pow(y.x - x.x, 2) + Math.Pow(y.y - x.y, 2));
        }
    }
}
