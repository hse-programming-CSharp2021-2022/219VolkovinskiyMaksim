using System;

namespace Task3
{
    class Program
    {
        public static int A(int m, int n)
        {
            if (m == 0)
                return n + 1;
            else if (m > 0 && n == 0)
                return A(m - 1, 1);
            else if (m > 0 && n > 0)
                return A(m - 1, A(m, n - 1));
            return 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(A(3, 1));
        }
    }
}
