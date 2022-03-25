using System;
namespace Combiner
{
   
    public delegate int[] Row(int n);
    public delegate void Print(int[] arr);
    
    class Task
    {
        public static int[] GetNumberDigits(int number) => Array.ConvertAll(number.ToString().ToCharArray(), input => Int32.Parse(input.ToString()));
        public static void PrintArray(int[] arr) => Array.ForEach(arr, digit => Console.Write(digit + " "));
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Creating number and array.
            var number = 12345;
            int[] arr = { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            
            Row row = Task.GetNumberDigits;
            Print print = Task.PrintArray;
            
            int[] digits = row(number);
            print(digits);
            Console.WriteLine();
            print(arr);
            Console.WriteLine();
            
            Console.WriteLine(row.Method);
            Console.WriteLine(row.Target); // null 
            Console.WriteLine();
            Console.WriteLine(print.Method);
            Console.WriteLine(print.Target); // null
        }
    }
}
