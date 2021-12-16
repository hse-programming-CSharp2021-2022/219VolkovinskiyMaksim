using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsolePlate[] arr = new ConsolePlate[]
            {
                new ConsolePlate(),
                new ConsolePlate('1', ConsoleColor.DarkRed),
                new ConsolePlate('0', ConsoleColor.White),
                new ConsolePlate('0', ConsoleColor.Red),
                new ConsolePlate('0', ConsoleColor.Gray),
                new ConsolePlate('-', ConsoleColor.DarkGray),
                new ConsolePlate('7', ConsoleColor.White),
                new ConsolePlate('?', ConsoleColor.DarkRed)
            };
            Array.ForEach(arr, x =>
            {
                Console.ForegroundColor = x.PlateColor;
                Console.Write(x.PlateChar);
                Console.ResetColor();
            });
        }
    }

    internal class ConsolePlate
    {
        private char _plateChar;
        private ConsoleColor _plateColor;

        public char PlateChar
        {
            get
            {
                return _plateChar;
            }
            private set
            {
                if ((int)value <= 31)
                    _plateChar = '+';
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

        public ConsolePlate()
        {
            PlateChar = '+';
        }

        public ConsolePlate(char c, ConsoleColor cc)
        {
            PlateChar = c;
            PlateColor = cc;
        }
    }
}
