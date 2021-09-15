using System;

namespace HW_2
{
    class Program
    {
        public static double F(double x, int num)
        {
            for (int i = 1; i <= num; i++)
                x += x;
            return x;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Для прекращения работы программы нажмите CTRL + Z + ENTER");
            double x;
            double x_1, x_2, x_3, x_4;
            do
            {
                string s = Console.ReadLine();
                if (s != null)
                {
                    while (!double.TryParse(s, out x))
                    {
                        Console.WriteLine("Incorrect input");
                    }
                    x_1 = x;
                    x_2 = x_1 * x_1;
                    x_3 = x_2 * x_1;
                    x_4 = x_2 * x_2;
                    Console.WriteLine("Значение полинома:\t" + (F(x_4, 12) + F(x_3, 9) - F(x_2, 3) + F(x_1, 2) - 4).ToString());
                }
                else
                    break;
            } while (true);
        }
    }
}
