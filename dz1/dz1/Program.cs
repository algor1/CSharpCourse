using System;

namespace dz
{
    class Program
    {
        static void Main(string[] args)
        {
            Dz1 d = new Dz1();
            d.Dz1_1();
        }
    }
    public class Dz1
    {
        public void Dz1_1()
        {
            Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет {name}!");

            Console.WriteLine("Введите число:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("И еще одно:");
            int y = int.Parse(Console.ReadLine());

            int z = x;
            x = y;
            y = z;
            Console.WriteLine($"Вы ввели числа {x} и {y}");

            Console.WriteLine();
            Console.WriteLine("Введите число");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine($"В этом числе {a.ToString().Length} цифр");
            Console.ReadKey();
        }

    }

}
