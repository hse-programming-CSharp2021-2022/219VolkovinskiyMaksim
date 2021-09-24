using System;

namespace Task6
{
    class Program
    {
        public static uint Fact (uint n)
        {
            if (n == 1)
                return 1;
            else
                return (n * Fact(n - 1));
        }

        public static double Sum1(double x)
        {
            double sum = x * x;
            uint a = 3, b = 4;
            double curr = Math.Pow(2,a) * Math.Pow(x,b) / Fact(b), prev = sum;
            sum -= curr;
            int n = 1;
            do
            {
                a += 2; b += 2;
                prev = curr;
                curr = Math.Pow(2, a) * Math.Pow(x, b) / Fact(b);
                switch (n % 2)
                {
                    case 0:
                        curr = -curr;
                        break;
                    case 1:
                        break;
                }
                sum += curr;
                n++;
            } while (prev != curr);
            return sum;
        }

        public static double Sum2(double x)
        {
            double curr = x, prev = 1;
            double sum = prev + curr;
            uint n = 2;
            do
            {
                prev = curr;
                curr = Math.Pow(x, n) / Fact(n);
                sum += curr;
                n++;
            } while (prev != curr);
            return sum;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(Sum1(1)); т.к вызывает StackOverflow Exception
            Console.WriteLine(Sum2(20));  //работает для n < 20, далее выводит знаки вопроса
            Console.WriteLine("\nРабота программы завершена. Нажмите любую клавишу, чтобы выйти из программы.");
            Console.ReadKey();
        }
    }
}
