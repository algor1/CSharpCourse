using System;
namespace dz
{
    //dz5
    static public class Calculator
    {
        static public void HeronTriangleArea()
        {
            Console.WriteLine($"Вычисление площади треуольника по трем сторонам {Environment.NewLine} Введите стороны треугольника:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (!checkTiangleData(a, b, c))
            {
                return;
            }

            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine($"Площадь треугольника равна {s}");

        }
    }
}
