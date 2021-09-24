using System;

namespace Task1
{
    class Program
    {
        public static bool Transform (ref uint numb)
        {
            uint res = 0;
            int l = 0;
            for (int i = 9; i >= 0; i--)
            {
                uint numb_copy = numb;
                while (numb_copy > 0)
                {
                    if (numb_copy % 10 == i)
                        res = res * 10 + (uint)i;
                }
            }
            numb = res;
            return true;
        }
        //99887__54321
        static void Main(string[] args)
        {
            uint numb = uint.Parse(Console.ReadLine());
            bool flag = Transform(ref numb);
            Console.WriteLine(numb);
        }
    }
}
