using System;

namespace Task7
{
    class Program
    {
        public static (int, double) F(double num)
        {
            int i = (int)num;
            double f = (num != 0) ? (Math.Abs(Math.Round(num - i,5))) : (0);
            return (i, f);
        }
        
        public static (dynamic, double) G(double num)
        {
            dynamic sqrt = (num >= 0) ? (Math.Sqrt(num)) : (false);
            double square = num * num;
            return (sqrt, square);
        }

        static void Main(string[] args)
        {
            do
            {
                double num;
                while (!double.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Incorrect input");
                }
                (int i, double f) = F(num);
                (dynamic sqrt, double square) = G(num);
                Console.WriteLine($"Целая часть числа: {i}\tДробная часть числа: {f}");
                Console.WriteLine($"Корень из числа (False, если корень вычислить невозможно): {sqrt}\tКвадрат числа: {square}");
                Console.WriteLine("Нажмите <ENTER>, чтобы продолжить;\n<CTRL> + <Z> + <ENTER>, чтобы прекратить работу программы; ");
                string s = Console.ReadLine();
                if (s == null)
                    break;
            } while (true);
        }
    }
}
