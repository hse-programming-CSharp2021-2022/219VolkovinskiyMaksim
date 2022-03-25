interface IFigure
{
    double S { get; }
    
}

class Square : IFigure
{
    public double S => Side * Side;
    private double Side { get; }

    public Square(double side)
    {
        this.Side = side;
    }
    
    public override string ToString() => $"Square with side {Side}";
}

class Circle : IFigure
{
    public double S => Math.PI*R*R;
    private double R { get; }

    public Circle(double r)
    {
        this.R = r;
    }

    public override string ToString() => $"Circle with radius {R}";
}

class Program
{
    static void Main()
    {
        
    }
    
    static void PrintInfo<T>(IFigure[] figures, double num)
        where T : IFigure
    {
        foreach (var figure in figures)
        {
            if (figure.S > num)
                Console.WriteLine(figure);
        }
    }
}