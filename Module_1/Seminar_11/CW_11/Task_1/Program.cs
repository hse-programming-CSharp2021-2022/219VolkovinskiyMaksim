using System;
using System.IO;
using System.Text;

namespace ConsoleApp23
{
    class Program
    {

        public static string GenereteText(int lines)
        {
            Random rand = new Random();
            StringBuilder res = new StringBuilder(1000);
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    res.Append(rand.Next(10, 101));
                    res.Append(' ');
                }
                res.Append(Environment.NewLine);
            }
            return res.ToString();
        }

        static void Main(string[] args)
        {
            string path = @"D:\file.txt";

            // Создаем файл с данными
            if (!File.Exists(path))
            {
                // Сейчас данные для записи вбиты в коде
                // TODO1: сохранить в файл целые случайные значения из диапазона [10;100)
                string createText = GenereteText(int.Parse(Console.ReadLine()));
                File.WriteAllText(path, createText, Encoding.UTF8);
            }

            // Open the file to read from
            if (File.Exists(path))
            {
                string readText = File.ReadAllText(path);
                string[] allLines= readText.Split(Environment.NewLine);
                int[] integerArray = new int[allLines.Length * 5];
                int i = 0;
                foreach (string line in allLines)
                {
                    string[] arr = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    foreach(string item in arr)
                    {
                        Console.Write(item + " ");
                        integerArray[i] = int.Parse(item);
                        i += 1;
                    }
                }

                StringBuilder evenIndexesString = new StringBuilder(1000);
                StringBuilder oddIndexesString = new StringBuilder(1000);
                for (int y = 0; y < integerArray.Length; y++)
                {
                    if (integerArray[y] % 2 == 0)
                    {
                        evenIndexesString.Append(y);
                        evenIndexesString.Append(' ');
                    }
                    else
                    {
                        oddIndexesString.Append(y);
                        oddIndexesString.Append(' ');
                    }
                }
                Console.WriteLine();
                int[] evenIndexes = StringArrayToIntArray(evenIndexesString.ToString().Split(' ', StringSplitOptions.RemoveEmptyEntries));
                Console.WriteLine("Индексы четных элементов:");
                Array.ForEach(evenIndexes, x => Console.Write(x + " "));
                Console.WriteLine();
                int[] oddIndexes = StringArrayToIntArray(oddIndexesString.ToString().Split(' ', StringSplitOptions.RemoveEmptyEntries));
                Console.WriteLine("Индексы нечетных элементов:");
                Array.ForEach(oddIndexes, x => Console.Write(x + " "));

                // обрабатываем элементы массива
                // TODO2: Создать два массива по исходному
                // в первый поместить индексы чётных элементов, во второй - нечётных
                // TODO3: Заменяем все нечётные числа исходного массива нулями
            }
        } // end of Main()


        // преобразование массива строк в массив целых чисел
        public static int[] StringArrayToIntArray(string[] str)
        {
            int[] arr = new int[str.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(str[i]);
            }
            return arr;
        } // end of StringToIntArray()
    } // end of Program
}
