using (BinaryWriter writer = new BinaryWriter(File.Open("note.txt", FileMode.OpenOrCreate)))
{
    for (int i = 0; i < 10; i++)
    {
        var r = new Random();
        writer.Write(r.Next().ToString());
    }
}

int[] arr = new int[10];
using (StreamReader reader = new StreamReader("note.txt"))
{
    for (int i = 0; i < 10; ++i)
    {
        arr[i] = reader.Read();
        Console.WriteLine(arr[i]);
    }
    int.TryParse(Console.ReadLine(), out int n);
    int min = 1000;
    int ind = 0;
    for (int i = 0; i < 10; ++i)
    {
        if (Math.Abs(n - arr[i]) < min)
        {
            min = Math.Abs(n - arr[i]);
            ind = i;
        }
    }
    arr[ind] = n;
}
using (StreamWriter writer = new StreamWriter("note.txt"))
{
    for (int i = 0; i < 10; ++i)
        writer.Write(arr[i]);
}
using (StreamReader reader = new StreamReader("note.txt"))
{
    for (int i = 0; i < 10; ++i)
    {
        arr[i] = reader.Read();
        Console.WriteLine(arr[i]);
    }
}