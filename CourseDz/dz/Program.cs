using System;

namespace dz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dz1 d = new Dz1();
            //Dz2 d = new Dz2();

            //d.Dz1_1();
            //d.HeronTriangleArea();

            //Dz3 d3 = new Dz3();
            //d3.Fibonachi();
            //d3.Mean();
            //d3.Factorial();
            //d3.Authefication();


            //Dz4 d4 = new Dz4();
            //d4.RomanNumeralsParser();
            Console.WriteLine(Calculator.HeronTriangleArea(3, 3, 3));
            Console.WriteLine(Calculator.HeronTriangleArea(3, 3, 3d));
            Console.ReadKey();
        }
    }
}
