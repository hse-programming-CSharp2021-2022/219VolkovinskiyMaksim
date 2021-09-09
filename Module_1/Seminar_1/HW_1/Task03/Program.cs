using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число от 32 до 127 :");
            byte Code = byte.Parse(Console.ReadLine());
            Console.WriteLine("{0} -ой/ый элемент таблицы ASCII содержит символ {1}", Code, (char)Code);
            Console.WriteLine("Работа программы окончена. Чтобы выйти, нажмите <ENTER>");
            Console.ReadLine();
        }
    }
}
