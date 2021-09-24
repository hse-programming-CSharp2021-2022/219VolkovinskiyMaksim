using System;

namespace Task1
{
    class Program
    {
        public static void Sums(uint number, out uint sumEven, out uint sumOdd)
        {
            sumEven = 0; sumOdd = 0;
            string s = number.ToString();
            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0)
                    sumOdd += (uint)s[i] - 48;
                else
                    sumEven += (uint)s[i] - 48;
            }
        }

        static void Main(string[] args)
        {
            Sums(1234, out uint sumEven, out uint sumOdd);
            Console.WriteLine($"sumEven: {sumEven}\tsumOdd: {sumOdd}");
        }
    }
}
