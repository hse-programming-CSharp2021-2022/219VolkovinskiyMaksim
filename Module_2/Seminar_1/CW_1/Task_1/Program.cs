using System;

namespace Task_1
{
    class RegularPolygon
    {
        int n;
        double rad;
        double p, s;

        public RegularPolygon(int N, double RAD)
        {
            n = N;
            rad = RAD;
        }

        public double P
        {
            get
            {
                return this.n * 2 * this.rad * Math.Tan(Math.PI / this.n);
            }
        }

        public double S
        {
            get
            {
                return P / 2 * rad;
            }
        }

        public string PolygonData()
        {
            return "Кол-во сторон : " + n.ToString() +
                "\nРадиус вписанной окр.-ти : " + rad.ToString() +
                "\nПериметр многоугольника : " + P.ToString() +
                "\nПлощадь многоугольника : " + S.ToString();
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            RegularPolygon polygon = new RegularPolygon(4,1);
            Console.WriteLine(polygon.PolygonData());

        }
    }
}
