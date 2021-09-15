using System;

namespace Task3
{
    class Program
    {
        public static (dynamic, dynamic) Calculate(double a, double b, double d)
        {
            dynamic x1 = (d >= 0) ? ((d == 0) ? (-b / (2 * a)) : ((-b - Math.Sqrt(d)) / (2 * a))) : ("");
            dynamic x2 = (d > 0) ? ((-b + Math.Sqrt(d)) / (2 * a)) : ("");
            return (x1, x2);
        }

        static void Main(string[] args)
        {
            do
            {
                double a, b, c;
                string s1, s2, s3;
                s1 = Console.ReadLine();
                s2 = Console.ReadLine();
                s3 = Console.ReadLine();
                while (!double.TryParse(s1, out a) || !double.TryParse(s2, out b) || !double.TryParse(s3, out c))
                {
                    Console.WriteLine("Incorrect input");
                    s1 = Console.ReadLine();
                    s2 = Console.ReadLine();
                    s3 = Console.ReadLine();
                }
                double d = b * b - (4 * a * c);
                (dynamic x1, dynamic x2) = Calculate(a, b, d);
                Console.WriteLine($"Корень 1: {x1}\tКорень 2: {x2}");
                Console.WriteLine("Нажмите <ENTER>, чтобы продолжить;\n<CTRL> + <Z> + <ENTER>, чтобы прекратить работу программы; ");
                string s = Console.ReadLine();
                if (s == null)
                    break;
            } while (true);
        }
    }
}
