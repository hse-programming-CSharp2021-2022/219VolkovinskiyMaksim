using System;


namespace ConsoleApp4
{
    class Program
    {
        public delegate string ConvertRule(string parametr);
        public class Converter
        {
            public string Convert(string s, ConvertRule cr)
            {
                return cr?.Invoke(s);
            }
        }
        public static string RemoveDigits(string s)
        {
            if (s == string.Empty)
                throw new ArgumentOutOfRangeException();
            while (s.IndexOfAny("0123456789".ToCharArray()) > -1)
                s = s.Remove(s.IndexOfAny("0123456789".ToCharArray()), 1);
            return s;
        }
        public static string RemoveSpaces(string str)
        {
            if (str == string.Empty)
                throw new ArgumentOutOfRangeException();
            while (str.IndexOfAny(" ".ToCharArray()) > -1)
                str = str.Remove(str.IndexOfAny(" ".ToCharArray()), 1);
            return str;
        }
        static void Main(string[] args)
        {
            string[] testStrings = {"asbf2123 askb 32 kjb23 e2", "123b231n",
                "de12132e", "1b0 15b bbd33cv", "abc", "dc1"};
            ConvertRule crMethod1 = RemoveDigits;
            Converter testConverter = new Converter();
            foreach (string s in testStrings)
                Console.WriteLine(testConverter.Convert(s, crMethod1));
            Console.WriteLine("-----------------------------------");
            ConvertRule crMethod2 = RemoveSpaces;
            foreach (string s in testStrings)
                Console.WriteLine(testConverter.Convert(s, crMethod2));
            Console.WriteLine("------------------------------------");
            ConvertRule crMethod3 = crMethod1 + crMethod2;
            foreach (string s in testStrings)
                Console.WriteLine(testConverter.Convert(s, crMethod3));
            Console.WriteLine("-------------------------------------");
            string ans = "";
            foreach (string s in testStrings)
            {
                ans = s;
                foreach (ConvertRule f in crMethod3.GetInvocationList())
                    ans = f(ans);
                Console.WriteLine(ans);
            }
        }
    }
}
