using System;

namespace Task2
{
    class Program
    {
        public static bool Shift (ref char ch)
        {
            //метод сдвигает символ на 4 единицы влево.
            if ((int)ch < 101 || (int)ch > 122)
                return false;
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    ch = (char)(((int)ch) - 1);
                    Console.Write(ch + " ");
                }
                return true;
            }
        }

        static void Main(string[] args)
        {
            char c;
            Console.Write("Введите символ латинского алфавита: ");
            while (!char.TryParse(Console.ReadLine(), out c))
                Console.WriteLine("Ошбика ввода. Введен не символ.");
            while (!Shift(ref c))
            {
                Console.WriteLine("Ошибка ввода. Введенный символ невозможно сдвинуть в алфавите на 4 позиции влево.");
                Console.Write("Введите символ латинского алфавита: ");
                while (!char.TryParse(Console.ReadLine(), out c))
                    Console.WriteLine("Ошбика ввода. Введен не символ.");
            }
            Console.WriteLine("\nРабота программы завершена. Нажмите любую клавишу, чтобы выйти из программы.");
            Console.ReadKey();
        }
    }
}
