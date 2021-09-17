using System;

namespace Task5
{
    class Program
    {
        public static int FindDels(int num)
        {
            int k = 0;
            for (int delitel = 1; delitel < (int)Math.Sqrt(num) + 1; delitel++)
            {
                if (num % delitel == 0)
                {
                    if (Math.Abs(delitel - Math.Sqrt(num)) < 0.001)
                        k += 1;
                    else
                        k += 2;
                }
            }
            return k;
        }

        static void Main(string[] args)
        {
            int k = 10, q = 0;
            for (int num = 100; num < 1000; num++)
            {
                if (FindDels(num) == k)
                    q++;
            }
            Console.WriteLine(q);
            Console.WriteLine(FindDels(121));
        }
    }
}
