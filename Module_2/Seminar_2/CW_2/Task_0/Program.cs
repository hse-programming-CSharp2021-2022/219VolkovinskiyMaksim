using System;

namespace Task_0
{
    class MyComplex
    {
        double re, im;

        public double RE { get { return re; } }
        public double IM { get { return im; } }

        public MyComplex(double xre = 0, double xim = 0)
        { re = xre; im = xim; }

        public static MyComplex operator ++(MyComplex mc)
        { return new MyComplex(mc.re + 1, mc.im + 1); }
        public static MyComplex operator --(MyComplex mc)
        { return new MyComplex(mc.re-1, mc.im-1);}

        public static MyComplex operator +(MyComplex mc1, MyComplex mc2)
        { return new MyComplex(mc1.re + mc2.re, mc1.im + mc2.im); }
        public static MyComplex operator -(MyComplex mc1, MyComplex mc2)
        { return new MyComplex(mc1.re - mc2.re, mc1.im - mc2.im); }
        public static MyComplex operator *(MyComplex mc1, MyComplex mc2)
        { return new MyComplex(mc1.re * mc2.re - mc1.im * mc2.im, mc1.im * mc2.re + mc2.im * mc1.re); }
        public static MyComplex operator /(MyComplex mc1, MyComplex mc2)
        {
            return new MyComplex((mc1.re * mc2.re + mc1.im * mc2.im) / (mc2.re * mc2.re + mc2.im * mc2.im),
              (mc1.im * mc2.re - mc1.re * mc2.im) / (mc2.re * mc2.re + mc2.im * mc2.im));
        }

    public double Mod() { return Math.Abs(re * re + im * im); }
    static public bool operator true(MyComplex f)
    {
        if (f.Mod() > 1.0) return true;
        return false;
    }
    static public bool operator false(MyComplex f)
    {
        if (f.Mod() <= 1.0) return true;
        return false;
    }
        public override string ToString()
        {
            return "re: " + re + "\tim: " + im;
        }
    }

class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            MyComplex c1 = new MyComplex(rand.Next(-100, 100), rand.Next(-10, 10));
            MyComplex c2 = new MyComplex(rand.Next(-100, 100), rand.Next(-10, 10));
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine();
            Console.WriteLine(c1 + c2);
            Console.WriteLine(c1 - c2);
            Console.WriteLine(c1 * c2);
            Console.WriteLine(c1 / c2);
        }
    }
}
