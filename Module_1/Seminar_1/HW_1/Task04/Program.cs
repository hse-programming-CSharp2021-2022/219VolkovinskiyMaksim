using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение напряжения U :");
            double u, r;
            while (!double.TryParse(Console.ReadLine(), out u))
            {
                Console.WriteLine("Введите корректное значение (целое или вещественное число)");
            }
            Console.WriteLine("Введите значение сопротивления R :");
            while (!double.TryParse(Console.ReadLine(), out r))
            {
                Console.WriteLine("Введите корректное значение (целое или вещественное число)");
            }
            Console.WriteLine("I = U / R = " + (u / r));
            Console.WriteLine("P = U * U / R = " + (u * u / r));
            Console.WriteLine("Работа программы окончена. Чтобы выйти, нажмите <ENTER>");
            Console.ReadLine();
        }
    }
}
