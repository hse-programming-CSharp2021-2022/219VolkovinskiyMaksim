public delegate double DelegateConvertTemperature(double temp);

class TemperatureConverterlmp
{
    public double CelstoFahr(double t) => (9 * t) / 5  + 32;

    public double FahrtoCels(double t) => 5 * (t - 32) / 9;
}

class StaticTempConverters
{
    public static double CtoK(double temperature) => temperature + 273.15;
    public static double KtoC(double temperature) => temperature - 273.15;

    public static double CtoR(double temperature) => (temperature + 273.15) * (double) 9 / 5;
    public static double RtoC(double temperature) => (temperature - 491.67) * (double) 5 / 9;

    public static double CtoRe(double temperature) => temperature * (double) 4 / 5;
    public static double RetoC(double temperature) => temperature * (double) 5 / 4;
}

class Program
{
    static void Main()
    {
        var _ = new TemperatureConverterlmp();
        DelegateConvertTemperature CtoF = _.CelstoFahr;
        DelegateConvertTemperature FtoC = _.FahrtoCels;

        Console.WriteLine(CtoF?.Invoke(0));
        Console.WriteLine(FtoC?.Invoke(32));
        
        List<DelegateConvertTemperature> delegateConvertTemperatures = new List<DelegateConvertTemperature>();
            
        delegateConvertTemperatures.Add(CtoF);
        delegateConvertTemperatures.Add(FtoC);

        delegateConvertTemperatures.Add(StaticTempConverters.CtoK);
        delegateConvertTemperatures.Add(StaticTempConverters.CtoR);
        delegateConvertTemperatures.Add(StaticTempConverters.CtoRe);

        string x;
        double data;
        Console.WriteLine("Введите значение температуры в градусах Цельсия:");
        x = Console.ReadLine();
        data = double.Parse(x);
        Console.WriteLine("|F|\t|K|\t|R|\t|Ré|\n" +
                          $"{delegateConvertTemperatures[0].Invoke(data)}\t" +
                          $"{delegateConvertTemperatures[2].Invoke(data)}" +
                          $"\t{delegateConvertTemperatures[3].Invoke(data)}\t" +
                          $"{delegateConvertTemperatures[4].Invoke(data)}");
    }
}