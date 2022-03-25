using System;

namespace ConsoleApp2
{
    public delegate int MyDel(int a, int b);


    static class TestClass
    {
        public static int max(int a, int b) => Math.Max(a, b);
    }
    static class TestClass2
    {
        public static int sum(int a, int b) => a+b;
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyDel d1 = TestClass.max;
            MyDel d2 = TestClass2.sum;
            MyDel d3 = TestClass.max;
            d3 += TestClass2.sum;
            Console.WriteLine(d1(3,4));
            Console.WriteLine(d2(3,4));
            Console.WriteLine(d3(3,4));
        }
    }
}
