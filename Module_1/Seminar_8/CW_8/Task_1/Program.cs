using System;

namespace Task_1
{
    class Program
    {
        public static int[] Generate(int len)
        {
            int[] arr = new int[len];
            Random rand = new Random();
            for (int i = 0; i < len; i++)
            {
                arr[i] = (int)rand.Next(1, 1001);
            }
            return arr;
        }

        public static int Even_Odd_Sort(int x, int y)
        {
            if (x % 2 == y % 2)
                return 1;
            else return -1;
        }

        public static int Count_Digits(int num)
        {
            int n = 0;
            while (num > 0)
            {
                num /= 10;
                n += 1;
            }
            return n;
        }

        public static int Sort_By_Digits(int x, int y)
        {
            if (Count_Digits(x) <= Count_Digits(y))
                return 1;
            else
                return -1;
        }

        public static int Sum_Of_Digits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }

        public static int Sort_By_Sum_Of_Digits(int x, int y)
        {
            if (Sum_Of_Digits(x) < Sum_Of_Digits(y))
                return 1;
            else
                return -1;
        }

        static void Main(string[] args)
        {
            int[] arr = Generate(10);
            //изначалльный массив
            Array.ForEach(arr, el => Console.Write(el + " "));
            Console.WriteLine();
            //сортировка массива по четности
            Array.Sort(arr, Even_Odd_Sort);
            Array.ForEach(arr, el => Console.Write(el + " "));
            Console.WriteLine();
            //сортировка массива по количеству цифр в числе
            Array.Sort(arr, Sort_By_Digits);
            Array.ForEach(arr, el => Console.Write(el + " "));
            Console.WriteLine();
            //сортировка по сумме цифр
            Array.Sort(arr, Sort_By_Sum_Of_Digits);
            Array.ForEach(arr, el => Console.Write(el + " "));
        }
    }
}
