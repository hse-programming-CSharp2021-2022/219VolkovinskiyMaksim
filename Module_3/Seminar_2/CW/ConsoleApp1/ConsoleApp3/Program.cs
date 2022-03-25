using System;

namespace ConsoleApp3
{

    public delegate double Sum(int n);

    class Program
    {
        static double sum1(int n)
        {
            double s = 0;
            for (int i = 1; i < n+1; i++)
            {
                for (int j = 1; j < i+1; j++)
                {
                    s += 1 / j;
                }
            }
            return s;
        }

        static double sum2(int n) {
            double s = 0;
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < i + 1; j++)
                {
                    s += 1 / Math.Pow(2,j);
                }
            }
            return s;
        }

        static void Main(string[] args)
        {
            Sum sum = sum1;
            Console.WriteLine(sum(5));
            sum += sum2;
            Console.WriteLine(sum(5));

        }
    }
}
