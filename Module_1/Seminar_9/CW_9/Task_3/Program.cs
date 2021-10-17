using System;

namespace Task_3
{
    class Program
    {
        public static string Task1(string s)
        {
            string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            return string.Join(' ', words);
        }

        public static int Task2(string s)
        {
            string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int count = 0;
            foreach (string word in words)
            {
                if (word.Length > 4)
                    count += 1;
            }
            return count;
        }

        public static int Task3(string s)
        {
            string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int count = 0;
            foreach (string word in words)
            {
                if ("уеыаоэяию".Contains(word[0].ToString().ToLower()))
                    count += 1;
            }
            return count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Task1("Мама      мыла              раму  "));
            Console.WriteLine(Task2("А     судьи                                     кто? "));
            Console.WriteLine(Task3("А    я пойду  а    я пойду    опять"));

        }
    }
}
