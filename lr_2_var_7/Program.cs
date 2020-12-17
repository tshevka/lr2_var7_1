using System;
using System.Collections.Generic;

namespace lr_2_var_7
{
    class Program
    {
       static void Main(string[] args)
        {
            Triangle triangle = new Triangle(new Point(1, 1), new Point(2, 3), new Point(4, 1));
            Rectangle rectangle = new Rectangle(new Point(4, 4), new Point(7, 1));
 
            List<Figure> figures = new List<Figure>() { triangle, rectangle };


 
            foreach(var item in figures)
            {
                Console.WriteLine("Square of the {0} = {1}", item.GetType().Name, item.GetSquare());
                Console.WriteLine("Perimeter of the {0} = {1}\n", item.GetType().Name, item.GetPerimeter());
            }

            Console.Write("Enter the number of vertexes: ");
            int n = int.Parse(Console.ReadLine());
            int[,] coord = new int[2, n];
            Console.WriteLine("Enter the vertex coordinates through a space");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter the coordinates of the vertex {0}: ", i + 1);
                var input = Console.ReadLine().Split(' ');
                coord[0, i] = int.Parse(input[0]);
                coord[1, i] = int.Parse(input[1]);
            }

            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < n - 1; i++)
            {
                sum1 += coord[0, i] * coord[1, i + 1];
                sum2 += coord[1, i] * coord[0, i + 1];
            }

            double square = Math.Abs((sum1 - sum2) / 2d);
            Console.WriteLine("The square of polygon is: {0}", square);

            Console.ReadLine();
        }
 
    }
 }



