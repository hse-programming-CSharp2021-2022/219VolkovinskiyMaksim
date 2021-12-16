using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyComplex mc = new MyComplex(0.1, 0.5);
            if (mc)
                Console.WriteLine(true);
            else
                Console.WriteLine(false);
        }
    }

    internal class MyComplex
    {
        public double Re { get; private set; }
        public double Im { get; private set; }

        public MyComplex(double re, double im)
        {
            Re = re;
            Im = im;
        }

        public double Mod()
        {
            return Math.Sqrt(Re * Re + Im * Im);
        }

        public static MyComplex operator --(MyComplex mc)
        {
            return new MyComplex(mc.Re - 1, mc.Im - 1);
        }

        public static bool operator true(MyComplex mc)
        {
            return mc.Mod() > 1;
        }

        public static bool operator  false(MyComplex mc)
        {
            return mc.Mod() <= 1;
        }
    }
}
