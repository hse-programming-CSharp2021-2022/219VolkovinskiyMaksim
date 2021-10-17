using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Let it be; All you need is Love; Dizzy Miss Lizzy";
            string[] sentences = s.Split(';');
            foreach (string sentence in sentences)
            {
                string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string abbr = string.Empty;
                foreach (string word in words)
                {
                    abbr += word[0].ToString().ToUpper();
                    if (!"aeyuio".Contains(word[0]))
                    {
                        for (int i = 1; i < word.Length; i++)
                        {
                            if ("aeyuio".Contains(word[i]))
                            {
                                abbr += word[i];
                                break;
                            }
                            else
                                abbr += word[i];
                        }
                    }
                }
                Console.WriteLine(abbr);
            }

        }
    }
}