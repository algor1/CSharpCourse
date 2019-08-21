using System;
namespace dz
{
    //dz5
    static public class Calculator
    {
        static public double HeronTriangleArea( double a, double b, double c)
        {
            Console.WriteLine($"Вычисление площади треуольника по трем сторонам ");
            if (!checkTiangleData(a, b, c))
            {
                return 0;
            }

            double p = (a + b + c) / 2;
            return  Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            //Console.WriteLine($"Площадь треугольника равна {s}");

        }
        static public double HeronTriangleArea(double a, double b, int degrees)
        {
            Console.WriteLine($"Вычисление площади треуольника по двум сторонам и углу в градусах");
            return a * b * Math.Sin(Math.PI * degrees / 180.0 ) / 2;
        }


        static private bool checkTiangleData(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0 || a + b <= c || a + c <= b || b + c <= a)
            {
                Console.WriteLine("Такого треугольника не может быть");
                return false;
            }
            return true;


        }
    }
}
