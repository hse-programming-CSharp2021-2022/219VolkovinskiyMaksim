﻿using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ/ы:");
            string c = Console.ReadLine();
            string p = "";
            while (p.Length < c.Length){
                p = p + " ";
            }
            Console.WriteLine("{0}{0}{1}{1}{0}{0}{0}{1}{1}{0}{1}{1}{0}{1}{0}{1}{0}{0}{0}{1}{0}{0}{1}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{0}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{1}{0}{1}", c, p);
            Console.WriteLine("{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{1}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}", c, p);
            Console.WriteLine("{0}{0}{1}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{0}{1}{1}{0}{1}{0}{1}{0}{0}{1}{1}{0}{1}{0}{1}{0}{0}{0}{1}{0}{1}{1}{1}{0}{0}{1}{1}{0}{1}{0}{1}{0}{1}{0}", c, p);
            Console.WriteLine("{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{1}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}", c, p);
            Console.WriteLine("{0}{0}{1}{1}{0}{0}{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}{0}{0}{0}{1}{0}{0}{1}{1}{0}{0}{0}{1}{0}{1}{0}{1}{0}{0}{0}{1}{0}{1}{0}{1}{0}{0}{0}{1}{0}{0}{0}", c, p);
            Console.WriteLine("Работа программы окончена. Чтобы выйти, нажмите <ENTER>");
            Console.ReadLine();
        }
    }
}
