public delegate int Cast(double arg);

internal static class Program
{
    private static void Main()
    {
        Cast round = d =>
        {
            int x = (int) Math.Round(d, MidpointRounding.ToEven);
            if (x % 2 == 0) 
                return x;
            else
            { 
                if (d > x) 
                    return x + 1;
                else 
                    return x - 1;
            }
        };
            
        Cast exp = d => ((int) d).ToString().Length - 1;
        

        Console.WriteLine(round?.Invoke(3.1241244));
        Console.WriteLine(exp?.Invoke(1234.2141));

        Cast cast = round + exp;

        Console.WriteLine(cast?.Invoke(2133.123132));

        cast -= exp;
        
        Console.WriteLine(cast?.Invoke(2133.123132));

        cast += exp;
        Delegate.Remove(cast, exp);

        Console.WriteLine(cast?.Invoke(2133.123132));


    }
}

