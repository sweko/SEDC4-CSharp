using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var fields = new List<Rectangle>
            {
                new Rectangle(10, 20),
                new Rectangle(20, 30),
                new Rectangle(30, 5),
                new Rectangle(15, 25),
                new Rectangle(30, 30)

            };

            double sumArea = 0;
            double sumPerimeter = 0;
            foreach (var field in fields)
            {
                sumArea += field.Area;
                sumPerimeter += 3 * field.Perimeter;
            }

            Console.WriteLine($"Total {sumArea} m2 za kopanje");
            Console.WriteLine($"Total {sumPerimeter} m za ograduvanje");

        }
    }

    class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double height, double width)
        {
            Width = width;
            Height = height;
        }

        public double Area
        {
            get
            {
                return Height * Width;
            }
        }

        public double Perimeter
        {
            get
            {
                return 2 * (Height + Width);
            }
        }
    }
}
