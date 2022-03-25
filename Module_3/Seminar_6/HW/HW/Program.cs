class Point
{
    public double X { get; set; }
    public double Y { get; set; }

    public Point(double x, double y) => (X, Y) = (x, y);

    public double Distance(Point p) => Math.Sqrt(Math.Pow(X - p.X, 2) + Math.Pow(Y - p.Y, 2));

    public override string ToString() => $"Point({X};{Y})";
}

class Circle : IComparable
{
    public Point Center { get; set; }
    public double Radius { get; set; }

    public Circle(double x, double y, double radius) => (Center, Radius) = (new Point(x, y), radius);

    public override string ToString() => $"Radius length is {Radius} and center of circle is {Center}";

    public int CompareTo(object? a)
    {
        if (a != null)
        {
            var x1 = this;
            var x2 = a as Circle;
            if (x1.Radius * x1.Center.Distance(new Point(0,0)) > x2.Radius * x2.Center.Distance(new Point(0,0)))
                return 1;
            if (x1.Radius * x1.Center.Distance(new Point(0,0)) - x2.Radius * x2.Center.Distance(new Point(0,0)) == 0)
                return 0;
            return -1;
        }

        return -2;
    }
}

class Program
{
    static void Main()
    {
        var circles = new List<Circle>(15);
        for (int i = 0; i < 15; i++)
            circles.Add(new Circle(new Random(i).Next(), new Random().Next(), 
                new Random(-1).Next() + new Random().NextDouble()));
        
        circles.Sort( (x1,x2) => (x1.Radius * x1.Center.Distance(new Point(0,0))).
            CompareTo(x2.Radius * x2.Center.Distance(new Point(0,0))));
        
        circles.Sort((circle, circle1) => circle.CompareTo(circle1));
        
        
    }
}


struct Circle1
{
    public Point1 Center { get; set; }
    public double Radius { get; set; }

    public Circle1(double x, double y, double radius) => (Center, Radius) = (new Point1(x, y), radius);

    public override string ToString() => $"Radius length is {Radius} and center of circle is {Center}";
}

struct Point1
{
    public double X { get; set; }
    public double Y { get; set; }

    public Point1(double x, double y) => (X, Y) = (x, y);

    public double Distance(Point p) => Math.Sqrt(Math.Pow(X - p.X, 2) + Math.Pow(Y - p.Y, 2));

    public override string ToString() => $"Point({X};{Y})";
}