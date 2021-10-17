using System;
using System.Text;
using System.Linq;

namespace Task_2
{
    class Program
    {
        public static string ConvertHex2Bin(string HexNumber)
        {
            StringBuilder res = new StringBuilder(100);
            const string alphabet = "0123456789ABCDEF";
            int num = 0, count = 0;
            for (int i = HexNumber.Length - 1; i >= 0; i--)
            {
                num += alphabet.IndexOf(HexNumber[i]) * (int)Math.Pow(16, count);
                count += 1;
            }

            while (num > 0)
            {
                res.Append(num % 2);
                num /= 2;
            }

            return Reverse(res);
        }

        public static string Reverse(StringBuilder s)
        {
            StringBuilder res = new StringBuilder(100);
            for (int i = s.Length - 1; i >= 0; i--)
            {
                res.Append(s[i]);
            }
            return res.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ConvertHex2Bin("F"));
            Console.WriteLine(ConvertHex2Bin("1A"));
            Console.WriteLine(ConvertHex2Bin("7"));
        }
    }
}
