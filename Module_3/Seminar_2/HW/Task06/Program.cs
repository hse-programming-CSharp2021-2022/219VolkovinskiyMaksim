using System.Threading.Channels;

class Plant
{
    public double Growth { get; set; }

    private double _sens;
    public double Photosensitivity
    {
        get => _sens;
        set
        {
            if (value is >= 0 and <= 100) 
                _sens = value;
            else
                throw new ArgumentException("Photosensitivity value must be >= 0 and <= 100");
        }
    }
    
    private double _res;
    public double FrostResistance
    {
        get => _res;
        set
        {
            if (value is >= 0 and <= 100)
                _res = value;
            else
                throw new ArgumentException("Frost resistance value must be >= 0 and <= 100");
        }
    }

    public Plant(double growth, double photosensitivity, double frostResistance)
    {
        Growth = growth;
        Photosensitivity = photosensitivity;
        FrostResistance = frostResistance;
    }

    public override string ToString() =>
        $"Growth is {Growth}; Photosensitivity is {Photosensitivity}; Frost resistance is {FrostResistance}";
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter number of plants: ");
        var n = int.Parse(Console.ReadLine());
        var plants = new Plant[n];
        for (int i = 0; i < n; i++)
        {
            var r = new Random();
            plants[i] = new Plant(r.Next(25,100) + r.NextDouble(), r.Next(0,100) + r.NextDouble(), r.Next(0,80) + r.NextDouble());
        }
        
        Array.ForEach( plants, x => Console.WriteLine(x));
        Console.WriteLine();
        plants = plants.OrderByDescending(x => x.Growth).ToArray();
        Array.ForEach( plants, x => Console.WriteLine(x));
        Console.WriteLine();
        plants = plants.OrderBy(x => x.FrostResistance).ToArray();
        Array.ForEach( plants, x => Console.WriteLine(x));
        Console.WriteLine();
        plants = plants.OrderBy(x => x.Photosensitivity % 2).ToArray();
        Array.ForEach( plants, x => Console.WriteLine(x));

        Array.ConvertAll(plants, x =>
        {
            if (x.FrostResistance % 2 is < 0.5 or > 1.5)
                x.FrostResistance /= 3;
            else
                x.FrostResistance /= 2;

            return x;
        });

        Console.WriteLine();
        Array.ForEach( plants, x => Console.WriteLine(x));
    }
}