using System;

namespace Task_2
{
    class Program
    {
        public static double[] Generate_Double_Array(int len)
        {
            double[] arr = new double[len];
            Random rand = new Random();
            for (int i = 0; i < len; i++)
            {
                arr[i] = rand.Next(-10, 11) + rand.NextDouble();
            }
            return arr;
        }

        public static (int[], double[]) Get_Int_And_Double_Arrays(double[] arr)
        {
            int[] int_arr = new int[arr.Length];
            double[] double_arr = new double[arr.Length];
            for(int i = 0; i < arr.Length; i++)
            {
                int_arr[i] = (int)arr[i];
                double_arr[i] = arr[i] - (int)arr[i];
            }
            return (int_arr, double_arr);
        }

        static void Main(string[] args)
        {
            double[] arr = Generate_Double_Array(10);
            Array.ForEach(arr, elem => Console.Write(elem + " "));
            Console.WriteLine();
            (int[] int_arr, double[] double_arr) = Get_Int_And_Double_Arrays(arr);
            Array.Sort(int_arr);
            Array.ForEach(int_arr, elem => Console.Write(elem + " "));
            Console.WriteLine();
            Array.Sort(double_arr);
            Array.ForEach(double_arr, elem => Console.Write(elem + " "));
        }
    }
}
