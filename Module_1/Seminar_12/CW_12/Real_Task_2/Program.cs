using System;
using System.Text.RegularExpressions;

namespace Real_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Console.WriteLine("1.");
            Regex regex = new Regex(@"\b[а-яА-Я]{4}\b");
            MatchCollection matches = regex.Matches(text);
            foreach (Match match in matches)
                Console.Write(match.Value + " ");
            Console.WriteLine(); Console.WriteLine();

            Console.WriteLine("2.");
            regex = new Regex(@"\b\w*а\b");
            matches = regex.Matches(text);
            foreach (Match match in matches)
                Console.Write(match.Value + " ");
            Console.WriteLine(); Console.WriteLine();

            Console.WriteLine("3.");
            regex = new Regex(@"\d+");
            matches = regex.Matches(text);
            int maxLen = 0;
            foreach(Match match in matches)
            {
                if (match.Value.Length > maxLen)
                    maxLen = match.Value.Length;
            }
            Console.WriteLine(maxLen);
        }
    }
}
