var random = new Random();
using (var writer = new BinaryWriter(File.Open("Numbers.txt", FileMode.OpenOrCreate)))
{
    for (var i = 0; i < 10; i++)
        writer.Write(random.Next(1, 101));
}

var data = new int[10];

using (var reader = new BinaryReader(File.Open("Numbers.txt", FileMode.OpenOrCreate)))
{
    for (var i = 0; i < 10; i++)
    {
        data[i] = reader.ReadInt32();
        Console.WriteLine(data[i]);
    }
    int n = int.Parse(Console.ReadLine());
    int min = -1, res = -1;
    for (int i = 0; i < 10; i++)
    {
        if (i == 0)
        {
            res = 0;
            min = Math.Abs(n - data[i]);
        }
        else
        {
            min = Math.Min(Math.Abs(n - data[i]), min);
            res = i;
        }
    }
    data[res] = n;
}
using (var writer = new BinaryWriter(File.Open("Numbers.txt", FileMode.OpenOrCreate)))
{
    for (var i = 0; i < 10; i++)
        writer.Write(data[i]);
}
using (var reader = new BinaryReader(File.Open("Numbers.txt", FileMode.OpenOrCreate)))
{
    for (var i = 0; i < 10; i++)
    {
        data[i] = reader.ReadInt32();
        Console.Write(data[i] + " ");
    }
}

