using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Real_Task_1
{
    class Program
    {
        public static int[] GenerateArray(int n)
        {
            Random rand = new Random();
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(1, 10001);
            return arr;
        }

        public static bool IsPalindrom(int num)
        {
            StringBuilder s1 = new StringBuilder(1000);
            StringBuilder s2= new StringBuilder(1000);
            string s = num.ToString();
            for (int i = 0; i < s.Length; i++)
                s1.Append(s[i]);
            while (num > 0)
            {
                s2.Append(num % 10);
                num /= 10;
            }
            if (s2.ToString() == s1.ToString())
                return true;
            else
                return false;
        }

        public static int FindDigitSum(int num)
        {
            int sum = 0;
            while(num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }

        public static int FindMaxDigit(int num)
        {
            int res = 0;
            while (num > 0)
            {
                if (num % 10 > res)
                    res = num % 10;
                num /= 10;
            }
            return res;
        }


        static void Main(string[] args)
        {
            int[] arr = GenerateArray(int.Parse(Console.ReadLine()));

            Console.WriteLine("1.");
            var selected1 = from item in arr
                            where (item % 3 == 0) && (item / 10 >= 1) && (item / 10 < 10)
                            select item;
            foreach (var item in selected1)
                Console.Write(item + " ");
            Console.WriteLine(); Console.WriteLine();

            Console.WriteLine("2.");
            var selected2 = from item in arr
                            where IsPalindrom(item)
                            orderby item
                            select item;
            foreach (var item in selected2)
                Console.Write(item + " ");
            Console.WriteLine(); Console.WriteLine();

            Console.WriteLine("3.");
            var selected3 = arr.OrderBy(x => FindDigitSum(x))
                .ThenBy(x => x);
            foreach (var item in selected3)
                Console.Write(item + " ");
            Console.WriteLine(); Console.WriteLine();

            Console.WriteLine("4.");
            var selected4 = arr.Where(x => x.ToString().Length == 4)
                .Select(x => x);
            int selected4Sum = 0;
            foreach (var item in selected4)
                selected4Sum += item;
            Console.WriteLine(selected4Sum);
            Console.WriteLine(); Console.WriteLine();

            Console.WriteLine("5.");
            var selected5 = arr.Where(x => (x >= 10) && (x <= 99))
                .OrderBy(x => x)
                .Select(x => x);
            Console.Write((selected5.FirstOrDefault() == 0) ? (string.Empty) : (selected5.FirstOrDefault()));
            Console.WriteLine(); Console.WriteLine();

            Console.WriteLine("6.");
            var selected6 = from item in arr
                            select FindMaxDigit(item);
            foreach (var item in selected6)
                Console.Write(item + " ");

        }
    }
}
