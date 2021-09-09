using System;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("Введите значение катета A :");
            while(!double.TryParse(Console.ReadLine(), out a)){
                Console.WriteLine("Введите корректное значение (целое или вещественное число)");
            }
            Console.WriteLine("Введите значение катета B :");
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Введите корректное значение (целое или вещественное число)");
            }
            double c = (Math.Sqrt(a * a + b * b));
            Console.WriteLine("Гипотенуза C = (A^2 + B^2)^0.5 = " + c);
            Console.ReadLine();
            Console.WriteLine("Работа программы окончена. Чтобы выйти, нажмите <ENTER>");
        }
    }
}
