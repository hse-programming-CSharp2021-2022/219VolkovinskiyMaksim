using System;

class TestClass
{
    public class Shape
    {
        public const double PI = Math.PI;
        protected double _x, _y;

        public Shape()
        {
        }

        public Shape(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public virtual double Area()
        {
            return _x * _y;
        }
    }

    public class Circle : Shape
    {
        public Circle(double r) : base(r, 0)
        {
        }

        public override double Area()
        {
            return PI * _x * _x;
        }
    }

    public class Sphere : Shape
    {
        public Sphere(double r) : base(r, 0)
        {
        }

        public override double Area()
        {
            return 4 * PI * _x * _x;
        }
    }

    public class Cylinder : Shape
    {
        public Cylinder(double r, double h) : base(r, h)
        {
        }

        public override double Area()
        {
            return 2 * PI * _x * _x + 2 * PI * _x * _y;
        }
    }

    static void Main()
    {
        Random rand = new Random();
        int n1 = rand.Next(3, 6);
        int n2 = rand.Next(3, 6);
        int n3 = rand.Next(3, 6);
        Shape[] arr = new Shape[n1 + n2 + n3];
        for (int i = 0; i < n1; i++)
            arr[i] = new Circle(rand.Next(1, 10));
        for (int i = n1; i < n1 + n2; i++)
            arr[i] = new Cylinder(rand.Next(5,10), rand.Next(5, 10));
        for (int i = n1 + n2; i < n1 + n2 + n3; i++)
            arr[i] = new Sphere(rand.Next(1, 10));
        foreach (Shape shape in arr)
        {
            if (shape is Circle)
                Console.Write("Circle: ");
            else if (shape is Cylinder)
                Console.Write("Cylinder: ");
            else if (shape is Sphere)
                Console.Write("Sphere: ");
            Console.WriteLine(shape.Area());
        }

    }
}