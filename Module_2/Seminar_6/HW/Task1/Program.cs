using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arr = new int[5];
                arr[5] = 1;
            }
            catch (IndexOutOfRangeException e) { Console.WriteLine(e.Message); }

            try
            {
                string s = null;
                s = s.Trim();
            }
            catch(NullReferenceException e) { Console.WriteLine(e.Message); }

            try
            {
                int a = 0;
                Console.WriteLine(5 / a);
            }
            catch(DivideByZeroException e) { Console.WriteLine(e.Message); }

            try
            {
                string s = null;
                Console.WriteLine("lol".IndexOf(s));
            }
            catch(ArgumentNullException e) { Console.WriteLine(e.Message); }

            try
            {
                string s = "123";
                Console.WriteLine(s.Substring(4));
            }
            catch(ArgumentOutOfRangeException e) { Console.WriteLine(e.Message); }

            try
            {
                string s = "a123";
                int a = Convert.ToInt32(s);
            }
            catch(FormatException e) { Console.WriteLine(e.Message); }

            try
            {
                char c = 'a';
                bool flag = Convert.ToBoolean(c);
            }catch(InvalidCastException e) { Console.WriteLine(e.Message); }

            try
            {
                throw new SorryMommyIAmDeadInsideException("1000-7?");
            }
            catch(SorryMommyIAmDeadInsideException e) { Console.WriteLine(e.Message); }
        }
    }

    public class SorryMommyIAmDeadInsideException : Exception
    {
        public SorryMommyIAmDeadInsideException() : base() { }
        public SorryMommyIAmDeadInsideException(string message) : base(message) { }
    }
}
