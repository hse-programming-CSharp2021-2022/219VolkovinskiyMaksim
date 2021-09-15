using System;

namespace Task2
{
    class Program
    {
        public static uint getInput()
        {
            uint num;
            string s = Console.ReadLine();
            if (s == null)
                return 0;
            else
            {
                while(!uint.TryParse(s, out num))
                {
                    Console.WriteLine("Incorrect input");
                    s = Console.ReadLine();
                    if (s == null)
                        return 0;
                }
                while (num < 100 || num > 999)
                {
                    Console.WriteLine("Incorrect input");
                    s = Console.ReadLine();
                    if (s == null)
                        return 0;
                }
                return num;
            }
        }

        public static uint getmax(uint a = 0, uint b = 0, uint c = 0)
        {
            return Math.Max(a, Math.Max(b, c));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Для прекращения работы программы нажмите CTRL + Z + ENTER");
            do
            {
                uint num = getInput();
                if (num == 0)
                    break;
                uint a, b, c;
                a = num % 10;
                num /= 10;
                b = num % 10;
                num /= 10;
                c = num;
                uint res = getmax(a = a, b = b, c = c) * 100;
                if (getmax(a = a, b = b, c = c) == a)
                {
                    res += getmax(b = b, c = c) * 10;
                    if (getmax(b = b, c = c) == b)
                        res += c;
                    else
                        res += b;
                }
                else if (getmax(a = a, b = b, c = c) == b)
                {
                    res += getmax(a = a, c = c) * 10;
                    if (getmax(a = a, c = c) == a)
                        res += c;
                    else
                        res += a;
                }
                else
                {
                    res += getmax(a = a, b = b) * 10;
                    if (getmax(a = a, b = b) == a)
                        res += b;
                    else
                        res += a;
                }
                Console.WriteLine(res);
            } while (true);
        }
    }
}
