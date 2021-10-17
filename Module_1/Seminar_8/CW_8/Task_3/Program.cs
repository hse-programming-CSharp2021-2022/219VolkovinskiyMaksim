using System;

namespace Task_3
{
    class Program
    {
        public static int[][] Generate_Jagged_Array(int len)
        {
            int[][] jagged_arr = new int[len][];
            Random rand = new Random();
            for (int i = 0; i < len; i++)
            {
                int jag_len = rand.Next(5, 16);
                jagged_arr[i] = new int[jag_len];
                for (int j = 0; j < jag_len; j++)
                {
                    jagged_arr[i][j] = rand.Next(-10, 11);
                }
            }
            return jagged_arr;
        }

        public static void Print_Array(int[] arr)
        {
            foreach (int item in arr)
                Console.Write(item + " ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[][] jagged_arr = Generate_Jagged_Array(7);
            Array.ForEach(jagged_arr, elem => Print_Array(elem));
        }
    }
}
