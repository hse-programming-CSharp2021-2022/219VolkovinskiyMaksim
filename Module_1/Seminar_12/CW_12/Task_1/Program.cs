using System;
using System.Linq;
using System.Collections.Generic;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Таня", "Лера", "Вика", "ВЕРОНИИИИКАААА" };
            var selected = from name in names
                           where name.ToLower().StartsWith("ве")
                           select name;
            foreach (var item in selected)
                Console.WriteLine(item + " ");
            
        }
    }
}
