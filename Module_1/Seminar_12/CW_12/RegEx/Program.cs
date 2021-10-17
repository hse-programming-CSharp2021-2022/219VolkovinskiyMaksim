using System;
using System.Text.RegularExpressions;

namespace RegEx
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Бык тупогуб, тупогубенький бычок, у быка губа бела была тупа";
            Regex regex = new Regex(@"туп\w*");
            var matches = regex.Matches(s);
            foreach (var match in matches)
                Console.Write(match + " ");
            Console.WriteLine();

            s = regex.Replace(s, "1111");
            Console.WriteLine(s);

            string s2 = "1111-111-1111";
            Regex regex2 = new Regex(@"^[0-9]{3}-\d{3}-\d{4}");
            Console.WriteLine(regex2.IsMatch(s2));
            Console.WriteLine(regex2.Match(s2));
        }
    }
}
