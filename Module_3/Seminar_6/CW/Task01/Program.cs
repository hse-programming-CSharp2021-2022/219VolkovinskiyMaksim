class Point
{
    private double X { get; set; }
    private double Y { get; set; }

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double Distance(Point p) => Math.Sqrt(Math.Pow(p.X - this.X, 2) + Math.Pow(p.Y - this.Y,2));

    public override string ToString() => $"x:{X};y:{Y}";
}

class Triangle
{
    private Point A { get; set; }
    private Point B { get; set; }
    private Point C { get; set; }
    private double AB => A.Distance(B);
    private double BC => B.Distance(C);
    private double AC => A.Distance(C);
    public double P => AB + BC + AC;
    private double p => P/2;
    public double S => Math.Sqrt(p * (p - AC) * (p - BC) * (p - AB));

    public Triangle(double ax, double ay, double bx, double by, double cx, double cy)
    {
        A = new Point(ax, bx);
        B = new Point(bx, by);
        C = new Point(cx, cy);
    }

    public Triangle(Point a, Point b, Point c)
    {
        A = a;
        B = b;
        C = c;
    }

    public bool IsInside(Point p) =>
        new Triangle(A, B, p).S + new Triangle(A, C, p).S + new Triangle(B, C, p).S - this.S == 0;

    public override string ToString() => $"A:{A}  B:{B}  C:{C}  AB:{AB}  AC:{AC}  BC:{BC}";
}

class Program
{
    static readonly Random Rnd = new();
    private static double GetRandomNumber => Rnd.Next(-100, 10) + Rnd.NextDouble();
    
    static void Main()
    {
        var k = Rnd.Next(1,20);
        var triangles = new Triangle[k];
        for (var i = 0; i < k; i++)
        {
            triangles[i] = new Triangle(new Point(GetRandomNumber, GetRandomNumber),
                new Point(GetRandomNumber, GetRandomNumber), new Point(GetRandomNumber, GetRandomNumber));
        }

        triangles = triangles.OrderBy(x => x.S).ToArray();
        Array.ForEach(triangles, x => Console.WriteLine(x));
        triangles = triangles.OrderBy(x => -x.P).ToArray();
        Array.ForEach(triangles, x => Console.WriteLine(x));
    }
}