using System;
using System.Linq;

namespace Task_2
{
    class Point
    {
        double X { get; set; }
        double Y { get; set; }
        public Point(double x = 0, double y = 0)
        {
            X = x;
            Y = y;
        }
        public double P
        {
            get { return Math.Sqrt(X * X + Y * Y); }
        }
        double F
        {
            get
            {
                if (X > 0 && Y >= 0)
                    return Math.Atan(Y / X);
                else if (X > 0 && Y < 0)
                    return Math.Atan(Y / X) + 2 * Math.PI;
                else if (X < 0)
                    return Math.Atan(Y / X) + Math.PI;
                else if (X == 0 && Y > 0)
                    return Math.PI / 2;
                else if (X == 0 && Y < 0)
                    return 3 * Math.PI / 2;
                else
                    return 0;
            }
        }
        public void PrintCoordinates() => Console.WriteLine($"Координата X: {X}\tКоордината Y: {Y}\n");

        public void PrintAllInfo()
        {
            PrintCoordinates();
            Console.WriteLine($"Полярная координата P: {P}\tПолярная координата F: {F}\n\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Point point1 = new Point(rand.Next(-100, 100), rand.Next(-100, 100));
            point1.PrintCoordinates();
            Point point2 = new Point(rand.Next(-100, 100), rand.Next(-100, 100));
            point2.PrintCoordinates();
            Console.Write("Введите координату X третьей точки: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите координату Y третьей точки: ");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Point point3 = new Point(x, y);
            Point[] points = new Point[] { point1, point2, point3 };

            var sortedPoints = from p in points
                               orderby (p.P)
                               select p;
            foreach (var item in sortedPoints)
                item.PrintAllInfo();

        }
    }
}
