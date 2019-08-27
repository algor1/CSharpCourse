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
            //Console.WriteLine(Calculator.HeronTriangleArea(3, 3, 3));
            //Console.WriteLine(Calculator.HeronTriangleArea(3, 3, 3d));
            //Complex c1 = new Complex(1, 1);
            //Complex c2 = new Complex(1, 2);

            //Complex result = c1.Plus(c2);
            //Console.WriteLine(result);
            //Console.WriteLine(c1.Substruct(c2));

            //MyStack<int> ms = new MyStack<int>();

            //for (int i = 0; i < 10; i++)
            //{
            //    ms.Push(i);
            //}
            //foreach (var item in ms)
            //{
            //    Console.WriteLine(item);
            //}



            //Console.WriteLine(ms.Peek());
            //Console.WriteLine(ms.Pop());
            //Console.WriteLine(ms.Peek());

            GuessNumber guessNumber = new GuessNumber(100, 5, Player.Human);
            guessNumber.Start();
            GuessNumber guessNumber1 = new GuessNumber(100, 5, Player.Machine);
            guessNumber1.Start();
            Console.ReadKey();
        }
    }
}
