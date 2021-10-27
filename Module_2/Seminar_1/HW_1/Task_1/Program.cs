using System;

namespace Task_1
{
    class RegularPolygon
    {
        int n;
        double rad;
        public RegularPolygon(int N = 0, double RAD = 0)
        {
            n = N;
            rad = RAD;
        }
        
        public double P
        {
            get { return (n != 0) ? (n * 2 * rad * Math.Tan(Math.PI / n)) : (0); }
        }

        public double S
        {
            get { return (n != 0 && n != 1) ? (n * rad * rad * Math.Tan(Math.PI / n)) : (0); }
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
        public static void PrintAllInfo(RegularPolygon[] polygonArray, double minS, double maxS)
        {
            foreach (var polygon in polygonArray)
            {
                if (polygon.S == minS)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(polygon.PolygonData());
                    Console.ResetColor();
                }
                else if (polygon.S == maxS)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(polygon.PolygonData());
                    Console.ResetColor();
                }
                else
                    Console.WriteLine(polygon.PolygonData());
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите количество правильных многоугольников в массиве: ");
            int q = int.Parse(Console.ReadLine());
            RegularPolygon[] polygonArray = new RegularPolygon[q];
            double minS = double.MaxValue, maxS = 0;
            for (int i = 0; i < q; i++)
            {
                Console.Write($"Введите количество сторон {i + 1}-ого многоугольника: ");
                int n = int.Parse(Console.ReadLine());
                Console.Write($"Введите радиус вписанной окружности для {i + 1}-ого многоугольника: ");
                double rad = double.Parse(Console.ReadLine());
                polygonArray[i] = new RegularPolygon(n, rad);
                if (polygonArray[i].S <= minS)
                    minS = polygonArray[i].S;
                if (polygonArray[i].S >= maxS)
                    maxS = polygonArray[i].S;
            }
            PrintAllInfo(polygonArray, minS, maxS);
        }
    }
}
