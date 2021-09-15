using System;

namespace Task4
{
    class Program
    {
        public static uint getInput(int i)
        {
            uint aud;
            Console.WriteLine($"Введите номер {i + 1} аудитории");
            while (!uint.TryParse(Console.ReadLine(), out aud))
            {
                Console.WriteLine("Incorrect input");
            }
            return aud;
        }

        static void Main(string[] args)
        {
            do
            {
                uint aud, res_aud = 1000, min_aud_on_stage = 99;
                for (int i = 0; i <= 2; i++)
                {
                    aud = getInput(i);
                    while (aud < 100 || aud > 999)
                    {
                        Console.WriteLine("Incorrect input");
                        aud = getInput(i);
                    }
                    if (aud % 100 <= min_aud_on_stage)
                    {
                        min_aud_on_stage = (aud % 100);
                        res_aud = aud;
                    }
                }
                Console.WriteLine($"Минимальный номер внутри этажа имеет аудитория {res_aud}");
                Console.WriteLine("Нажмите <ENTER>, чтобы продолжить;\n<CTRL> + <Z> + <ENTER>, чтобы выйти из программы");
                if (Console.ReadLine() == null)
                    break;
            } while (true);
        }
    }
}
