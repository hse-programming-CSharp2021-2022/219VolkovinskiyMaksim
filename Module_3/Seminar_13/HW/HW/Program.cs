
using System.Collections;


internal class Fibonacci : IEnumerable
{ 
    private int f0 = 1, f1 = 1;
    public IEnumerator GetEnumerator()
    { 
        for (var i = 0; i < 10; ++i) 
        { 
            yield return f0;
            int c = f0; 
            f0 = f1; 
            f1 += c;
        }
    }
    public IEnumerable NameEnumerator(int n)
    {
        int F0 = 1, F1 = 1;
        for (var i = 0; i < n; ++i)
        {
            yield return F0;
            int c = F0;
            F0 = F1;
            F1 += c;
        }
    }
}
internal class TriangleNums : IEnumerable
{
    private int num = 1;
    public IEnumerator GetEnumerator()
    {
        for (int i = 0; i < 10; ++i)
        {
            yield return num;
            num += i + 2;
        }
    }
    public IEnumerable NameEnumerator(int num)
    {
        for (var i = 0; i < num; ++i)
        {
            yield return this.num;
            this.num += i + 2;
        }
    }
}


internal class Program
{
    private static void Main()
    {
        var fib = new Fibonacci();
        var triangleNums = new TriangleNums();
        var data = new int[10];

        var workingIndex = 0;
        foreach (object? item in fib.NameEnumerator(10))
        {
            Console.WriteLine(item);
            data[workingIndex++] = (int)item;
        }

        Console.WriteLine("###########################");

        workingIndex = 0;
        foreach (object? item in triangleNums.NameEnumerator(10))
        {
            Console.WriteLine(item);
            data[workingIndex++] += (int)item;
        }

        Console.WriteLine("###########################");

        foreach (int item in data)
        {
            Console.WriteLine(item);
        }
    }
}


