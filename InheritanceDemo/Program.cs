using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Field f = new RectangleField(10, 10);
            //Console.WriteLine(f.Area);
            //Console.WriteLine(f.Perimeter);
            //return;

            var fields = new List<Field>
            {
                new RectangleField(10, 20),
                new RectangleField(20, 30),
                new RectangleField(30, 5),
                new RectangleField(15, 25),
                new RectangleField(30, 30),
                new CircleField(30),
                new CircleField(20),
                new TriangleField(3,4,5),
                new TriangleField(5,12,13)
            };

            double sumArea = 0;
            double sumPerimeter = 0;
            foreach (Field field in fields)
            {
                sumArea += field.Area;
                sumPerimeter += 3 * field.Perimeter;
            }

            Console.WriteLine($"Total {sumArea} m2 za kopanje");
            Console.WriteLine($"Total {sumPerimeter} m za ograduvanje");

        }
    }

    class Field {
        public virtual double Area {
            get
            {
                return 0;
            }
        }

        public virtual double Perimeter
        {
            get
            {
                return 0;
            }
        }

    }

    class RectangleField : Field
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public RectangleField(double height, double width)
        {
            Width = width;
            Height = height;
        }

        public override double Area
        {
            get
            {
                return Height * Width;
            }
        }

        public override double Perimeter
        {
            get
            {
                return 2 * (Height + Width);
            }
        }
    }

    class CircleField: Field
    {
        public double Radius { get; set; }

        public CircleField(double radius)
        {
            Radius = radius;
        }

        public override double Area
        {
            get
            {
                return Radius * Radius * Math.PI;
            }
        }

        public override double Perimeter
        {
            get
            {
                return 2 * Radius * Math.PI;
            }
        }
    }

    class TriangleField : Field
    {
        public double First { get; set; }
        public double Second { get; set; }
        public double Third { get; set; }

        public TriangleField(double first, double second, double third)
        {
            First = first;
            Second = second;
            Third = third;
        }

        public override double Area
        {
            get
            {
                var s = (First + Second + Third) / 2;
                return Math.Sqrt(s * (s-First) * (s - Second) * (s - Third));
            }
        }

        public override double Perimeter
        {
            get
            {
                return First + Second + Third;
            }
        }
    }
}
