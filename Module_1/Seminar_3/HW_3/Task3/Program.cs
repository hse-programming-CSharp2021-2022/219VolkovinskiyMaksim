using System;

namespace Task3
{
    class Program
    {
        public static double G(double x)
        {
            if (x <= 0.5)
                return Math.Sqrt(2) / 2;
            else
                return Math.Sin((Math.PI * (x - 1)) / 2);
        }

        public static double getInput()
        {
            double x;
            Console.WriteLine("Введите координату X");
            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Incorrect input");
            }
            return x;
        }

        static void Main(string[] args)
        {
            do
            {
                double x = getInput();
                Console.WriteLine($"Значение функции G = {G(x)}");
                Console.WriteLine("Нажмите <ENTER>, чтобы продолжить;\n<CTRL> + <Z> + <ENTER>, чтобы выйти из программы");
                if (Console.ReadLine() == null)
                    break;
            } while (true);
        }
    }
}
