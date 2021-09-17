using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            float prev = (float)1.0 / (1 * 2 * 3);
            float cur = (float)1.0 / (2 * 3 * 4);
            int i = 3;
            while (cur != prev)
            {
                prev = cur;
                cur = (float)1.0 / (i * (i + 1) * (i + 2));
                i++;
            }
            Console.WriteLine($"FLOAT. Current: {cur}\tPrevious: {prev}");

            double prevv = 1.0 / (1 * 2 * 3);
            double curr = 1.0 / (2 * 3 * 4);
            i = 3;
            while (curr > prevv)
            {
                prevv = curr;
                curr = 1.0 / (i * (i + 1) * (i + 2));
                i++;
            }
            Console.WriteLine($"DOUBLE. Current: {curr}\tPrevious: {prevv}");
        }
    }
}
