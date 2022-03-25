class Program
{
    private static readonly Random Random = new Random();

    private static async Task<double> Integral(Func<double, double> func, int a, int b, int n)
    {
        int correct = 0;
        int minX = a, maxX = b;
        int maxY = (int) Math.Max(func(a), func(b)) + 1;
        
        for (int i = 0; i < n; i++)
        {
            await Task.Run(() =>
            {
                double x = Random.Next(minX, maxX) + Random.NextDouble();
                double y = Random.Next(0, maxY) + Random.NextDouble();
                if (y <= func(x))
                {
                    correct++;
                }
            });
        }

        return (double) correct / n * (maxX - minX) * maxY;
    }

    static async Task Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        var l = new List<double>();
        for (int i = a; i <= b; i+=2)
        {
            await Task.Run( async () =>
            {
                double integr = await Integral(x => x * x, i, i + 2, Random.Next(0, 1000));
                l.Add(integr);
            });
        }
        Array.ForEach(l.ToArray(), Console.WriteLine);
    }
}
