using System;

namespace Task5
{
    class Program
    {

        public static (double a, double b, double c) getInput()
        {
            double a, b, c;
            string s1, s2, s3;
            s1 = Console.ReadLine();
            s2 = Console.ReadLine();
            s3 = Console.ReadLine();
            while (!double.TryParse(s1, out a) || !double.TryParse(s2, out b) || !double.TryParse(s3, out c))
            {
                Console.WriteLine("Incorrect input");
                s1 = Console.ReadLine();
                s2 = Console.ReadLine();
                s3 = Console.ReadLine();
            }
            return (a, b, c);
        }

        static void Main(string[] args)
        {
            do
            {
                (double a, double b, double c) = getInput();
                while (a <= 0 || b <= 0 || c <= 0)
                {
                    Console.WriteLine("Incorrect input");
                    (a, b, c) = getInput();
                }
                bool possible = (a < b + c) ? ((b < a + c) ? ((c < a + b) ? (true) : (false)) : (false)) : (false);
                Console.WriteLine(possible);
                Console.WriteLine("Нажмите <ENTER>, чтобы продолжить;\n<CTRL> + <Z> + <ENTER>, чтобы прекратить работу программы; ");
                string s = Console.ReadLine();
                if (s == null)
                    break;
            } while (true);
        }
    }
}
