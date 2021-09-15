using System;

namespace HW_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Incorrect input");
            }
            double x_1 = x,
                x_2 = x_1 * x_1,
                x_3 = x_2 * x_1,
                x_4 = x_2 * x_2;
            Console.WriteLine("Значение полинома:\t" + (12 * x_4 + 9 * x_3 - 3 * x_2 + 2 * x_1 - 4).ToString());
            Console.WriteLine("Работа программы завершена. Для выхода из программы нажмите клавишу <ENTER>");
            Console.ReadLine();
        }
    }
}
