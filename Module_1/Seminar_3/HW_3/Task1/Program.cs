using System;

namespace Task1
{
    class Program
    {
        public static bool G(double x, double y)
        {
            if (x >= 0 && y <= x && x * x + y * y <= 4)
                return true;
            else
                return false;
        }

        public static (double, double) getInput()
        {
            double x, y;
            Console.WriteLine("Введите координату X");
            while(!double.TryParse(Console.ReadLine(), out x))
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
                Console.WriteLine($"Точка с координатами ({x};{y}) попадает в фигуру G? - {G(x, y)}");
                Console.WriteLine("Нажмите <ENTER>, чтобы продолжить;\n<CTRL> + <Z> + <ENTER>, чтобы выйти из программы");
                if (Console.ReadLine() == null)
                    break;
            } while (true);
        }
    }
}
