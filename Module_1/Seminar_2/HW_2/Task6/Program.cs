using System;

namespace Task6
{
    class Program
    {
        public static (double budget, byte perc) getInput()
        {
            double budget;
            byte perc;
            string s1, s2;
            s1 = Console.ReadLine();
            s2 = Console.ReadLine();
            while (!double.TryParse(s1, out budget) || !byte.TryParse(s2, out perc))
            {
                Console.WriteLine("Incorrect input");
                s1 = Console.ReadLine();
                s2 = Console.ReadLine();
            }
            return (budget, perc);
        }

        static void Main(string[] args)
        {
            do
            {
                double budget;
                byte perc;
                (budget, perc) = getInput();
                while (budget <= 0 || perc > 100)
                {
                    Console.WriteLine("Incorrect input");
                    (budget, perc) = getInput();
                }
                Console.WriteLine("Бюджет на комп. игры: {0:C}", budget / 100 * perc);
                Console.WriteLine("Нажмите <ENTER>, чтобы продолжить;\n<CTRL> + <Z> + <ENTER>, чтобы прекратить работу программы; ");
                string s = Console.ReadLine();
                if (s == null)
                    break;
            } while (true);
        }
    }
}
