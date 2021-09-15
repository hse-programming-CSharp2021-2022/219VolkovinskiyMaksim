using System;

namespace ConsoleApp1
{
    class Program
    {
        public static int F(int num)
        {
            if (num == 1)
                return 1;
            else
                return num * F(num - 1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(F(5));
        }
    }
}
