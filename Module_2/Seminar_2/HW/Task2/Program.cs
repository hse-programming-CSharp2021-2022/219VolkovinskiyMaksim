using System;
using System.Text.RegularExpressions;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsolePlate X = new ConsolePlate('X', ConsoleColor.White, ConsoleColor.Red);
            ConsolePlate O = new ConsolePlate('O', ConsoleColor.White, ConsoleColor.Magenta);
            int n = 16;
            for (int i = 0; i < n * n; i++)
            {
                if (i % n == 0)
                    Console.Write('\n');
                if (i % 2 == 0)
                    X.Print();
                else
                    O.Print();
            }
        }
    }

    internal class ConsolePlate
    {
        private char _plateChar;
        private ConsoleColor _plateColor;
        private ConsoleColor _bgColor;
        private Regex regex = new Regex(@"[A-Z]");

        public char PlateChar
        {
            get
            {
                return _plateChar;
            }
            private set
            {
                if (!regex.IsMatch(value.ToString()))
                    throw new ArgumentException("По русски сказано - только заглавные символы латинского алфавита.");
                else
                    _plateChar = value;
            }
        }

        public ConsoleColor PlateColor
        {
            get
            {
                return _plateColor;
            }
            private set
            {
                _plateColor = value;
            }
        }

        public ConsoleColor BackgroundColor
        {
            get
            {
                return _bgColor;
            }
            private set
            {
                if (value == PlateColor)
                    throw new ArgumentException("НЕЛЬЗЯ СДЕЛАТЬ ФОН И ШРИФТ ОДИНАКОВОГО ЦВЕТА " +
                        "НУ РАЗВЕ ЭТО НЕ ОЧЕВИДНО СКАЖИТЕ МНЕ ПОЖАЛУЙСТА");
                else
                    _bgColor = value;
            }
        }

        public ConsolePlate()
        {
            PlateChar = 'A';
        }

        public ConsolePlate(char c, ConsoleColor cc, ConsoleColor bgc)
        {
            PlateChar = c;
            PlateColor = cc;
            BackgroundColor = bgc;
        }

        public void Print()
        {
            Console.BackgroundColor = BackgroundColor;
            Console.ForegroundColor = PlateColor;
            Console.Write(PlateChar);
            Console.ResetColor();
        }
    }
}
