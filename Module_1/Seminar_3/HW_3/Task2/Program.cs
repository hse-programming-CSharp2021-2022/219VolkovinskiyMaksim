using System;

namespace Task2
{
    class Program
    {
        public static double G(double x, double y)
        {
            if (x < y && x > 0)
                return x + Math.Sin(y);
            else if (x > y && x < 0)
                return y - Math.Cos(x);
            else
                return 0.5 * x * y;
        }

        public static (double, double) getInput()
        {
            double x, y;
            Console.WriteLine("Введите координату X");
            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Incorrect input");
            }
            Console.WriteLine("Введите координату Y");
            while (!double.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Incorrect input");
            }
            return (x, y);
        }

        static void Main(string[] args)
        {
            do
            {
                (double x, double y) = getInput();
                Console.WriteLine($"Значение функции G = {G(x, y)}");
                Console.WriteLine("Нажмите <ENTER>, чтобы продолжить;\n<CTRL> + <Z> + <ENTER>, чтобы выйти из программы");
                if (Console.ReadLine() == null)
                    break;
            } while (true);
        }
    }
}
