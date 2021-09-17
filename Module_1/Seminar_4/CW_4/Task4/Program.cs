using System;

namespace Task4
{
    class Program
    {
        public static double F(double cap, int r, int n)
        {
            if (n == 0)
                return cap;
            return F(cap, r, n - 1) * (1 + (r / 100.0));
        }

        static void Main(string[] args)
        {
            Console.WriteLine(F(1000, 10, 2));
            double cap = 1000;
            int r = 10, n = 2;
            for (int i = 0; i < n; i++)
            {
                cap = cap * (1 + (r / 100.0));
            }
            Console.WriteLine(cap);
        }
    }
}
