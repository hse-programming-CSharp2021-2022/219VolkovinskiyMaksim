using System;

namespace Task_2
{
    class Program
    {
        public static int[] Create()
        {
            int[] arr = new int[100];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }
            for (int i = 0; i < 44; i++)
            {
                int ind1 = rand.Next(0, 100);
                int ind2 = rand.Next(0, 100);
                int intermediate = arr[ind1];
                arr[ind1] = arr[ind2];
                arr[ind2] = intermediate;
            }
            Array.Resize(ref arr, 99);
            return arr;
        }
        static void Main(string[] args)
        {
            var arr = Create();
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum1 += i;
            }

            foreach(int num in arr)
            {
                sum2 += num;
            }

            Console.WriteLine(sum1 - sum2);
        }
    }
}
