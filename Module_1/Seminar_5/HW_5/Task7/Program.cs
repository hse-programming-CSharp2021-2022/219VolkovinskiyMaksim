using System;

namespace Task7
{
    class Program
    {
        public static void Nod_Nok (uint a, uint b, out uint nod, out uint nok)
        {
            nod = 1; nok = a * b;
            //ищем НОД
            for (uint delitel = (a < b) ? (b) : (a); delitel >= 2; delitel--)
            {
                if(a % delitel == 0 && b % delitel == 0)
                {
                    nod = delitel;
                    break;
                }
            }
            //ищем НОК
            for (uint num = (a < b) ? (b) : (a); num < a * b; num++)
            {
                if (num % a == 0 && num % b == 0)
                {
                    nok = num;
                    break;
                }
            }
        }

        static void Main(string[] args)
        {
            uint a = 4, b = 3;
            Nod_Nok(a, b, out uint nod, out uint nok);
            Console.WriteLine($"Наибольший Общий Делитель чисел {a} и {b}: {nod}\n" +
                $"Наименьшее Общее Кратное чисел {a} и {b}: {nok}");
            Console.WriteLine("\nРабота программы завершена. Нажмите любую клавишу, чтобы выйти из программы.");
            Console.ReadKey();
        }
    }
}
