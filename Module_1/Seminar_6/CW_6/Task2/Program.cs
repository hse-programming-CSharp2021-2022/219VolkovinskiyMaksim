using System;

namespace Task2
{
    class Program
    {
        public static int Compress(ref int[] mas)
        {
            foreach (int item in mas)
                Console.Write(item + " ");
            Console.WriteLine();
            int factual_elems = mas.Length;
            for (int i = 0; i < mas.Length - 1; i++)
            {
                if (i + 1 >= factual_elems)
                    return factual_elems;
                if ((mas[i] + mas[i+1]) % 3 == 0)
                {
                    mas[i] = mas[i] * mas[i + 1];
                    for (int j = i + 1; j < mas.Length - 1; j++)
                        mas[j] = mas[j + 1];
                    factual_elems -= 1;
                }
                
                foreach (int item in mas)
                    Console.Write(item + " ");
                Console.WriteLine();
            }
            return 0;
        }

        static void Main(string[] args)
        {
            int[] mass = { 1, 2, 3, 4, 5, 6 };
            int factual_elems = Compress(ref mass);
            for (int i = 0; i < factual_elems; i++)
            {
                Console.Write(mass[i] + " ");
            }
        }
    }
}
