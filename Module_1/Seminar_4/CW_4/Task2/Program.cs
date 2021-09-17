using System;

namespace Task2
{
    class Program
    {
        public static double F(double a, double b, double delta)
        {
            double s = 0;
            int y = 0;
            for (int i = 0; i < (int)(Math.Abs(b - a) / delta); i++)
            {
                s += ((a + i * delta) * (a + i * delta) + (a + (i + 1) * delta) * (a + (i + 1) * delta)) / 2 * delta;
                y++;
            }
            if (Math.Abs(b - a) - (y * delta) > 0)
            {
                s += ((a + y * delta) * (a + y * delta) + (b * b)) / 2 * (b - y * delta);
            }
        }

        static void Main(string[] args)
        {
            
        }
    }
}
