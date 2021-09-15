using System;

namespace Task4
{
    class Program
    {
        public static uint getInput()
        {
            uint num;
            while (!uint.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Incorrect input");
            }
            return num;
        }

        static void Main(string[] args)
        {
            do
            {
                uint num = getInput();
                while (num < 1000 || num > 9999)
                {
                    Console.WriteLine("Incorrect input");
                    num = getInput();
                }
                while (num > 0)
                {
                    Console.WriteLine(num % 10);
                    num /= 10;
                }
                Console.WriteLine("Нажмите <ENTER>, чтобы продолжить;\n<CTRL> + <Z> + <ENTER>, чтобы прекратить работу программы; ");
                string s = Console.ReadLine();
                if (s == null)
                    break;
            } while (true);
        }
    }
}
