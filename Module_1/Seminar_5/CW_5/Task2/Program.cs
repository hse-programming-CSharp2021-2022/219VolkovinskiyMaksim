using System;

namespace Task2
{
    class Program
    {
        public static double F(uint n)
        {
            double s = 0;
            for (int k = 1; k<=n; k++)
            {
                s = s + (k + 0.3) / (3 * k * k + 5);          
            }
            return s;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(F(3));
        }
    }
}
