using System.Reflection;

abstract class Animal : IComparable
{
    public int Age { get; set; }
    public override string ToString() => $"{this.GetType()} with age {Age}";
    
    public Animal() {}

    public int CompareTo(Object a)
    {
        if (this.Age > ((Animal)a).Age) 
            return 1;
        if (this.Age == ((Animal)a).Age)
            return 0;
        return -1;
    }
}

interface IJump
{
    public void Jump(Animal animal) => Console.WriteLine($"{animal} jumped");
    public double JumpLength { get; set; }
}

interface IRun
{
    public void Run(Animal animal) => Console.WriteLine($"{animal} running");
    public double Speed { get; set; }
}

class Cockroach : Animal, IRun
{
    public double Speed { get; set; }
    
    public Cockroach(double speed, int age)
    {
        Speed = speed;
        Age = age;
    }
    
    public override string ToString() => base.ToString() + $" and with speed {Speed}";
}



class Kangaroo : Animal, IJump
{
    public double JumpLength { get; set; }
    
    public Kangaroo(double jumpLength, int age)
    {
        JumpLength = jumpLength;
        Age = age;
    }
    
    public override string ToString() => base.ToString() + $" and with jump length {JumpLength}";
}

class Cheetah : Animal, IRun, IJump
{
    public double JumpLength { get; set; }
    public double Speed { get; set; }
    
    public Cheetah(double jumpLength, double speed, int age)
    {
        Speed = speed;
        JumpLength = jumpLength;
        Age = age;
    }
    
    public override string ToString() => base.ToString() + $" and with jump length {JumpLength} and with speed {Speed}";
}

class CockroachComparer : IComparer<Cockroach?>
{
    public int Compare(Cockroach? lhs, Cockroach? rhs)
    {
        if (lhs.Speed < rhs.Speed) return 1;
        if (lhs.Speed > rhs.Speed) return -1;
        return 0;
    }
}

class KangarooComparer : IComparer<Kangaroo?>
{
    public int Compare(Kangaroo? lhs, Kangaroo? rhs)
    {
        if (lhs.JumpLength < rhs.JumpLength) return 1;
        if (lhs.JumpLength > rhs.JumpLength) return -1;
        return 0;
    }
}

class Program
{
    private static Random r = new Random();
    private static int RandomInt(int max) => r.Next(0,max);
    private static double RandomDouble(int max) => r.Next(0,max-1) + r.NextDouble();
    
    static void Main()
    {
        var animals = new Animal[]
        {
            new Cockroach(RandomDouble(5), RandomInt(2)), new Cockroach(RandomDouble(5), RandomInt(2)),
            new Kangaroo(RandomDouble(5), RandomInt(15)), new Kangaroo(RandomDouble(5), RandomInt(15)),
            new Cheetah(RandomDouble(5), RandomDouble(100), RandomInt(20)),
            new Cheetah(RandomDouble(5), RandomDouble(100), RandomInt(20))
        };
        var jumping = animals.Where(x => x is IJump).ToArray();
        Array.ForEach(jumping, x => Console.WriteLine(x));
        var running = animals.Where(x => x is IJump).ToArray();
        Array.ForEach(running, x => Console.WriteLine(x));
        var cockroaches = running.Where(x => x is Cockroach).ToArray();
        var kangaroos = jumping.Where(x => x is Kangaroo).ToArray();
        var f = Array.ConvertAll(cockroaches, x => x as Cockroach);
        var g = Array.ConvertAll(kangaroos, x => x as Kangaroo);
        Array.Sort(f, new CockroachComparer());
        Array.Sort(g, new KangarooComparer());
    }
}


