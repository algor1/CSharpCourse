using System;

namespace dz
{
    public class Dz2
    {
        public void Max()
        {
            Console.WriteLine("Введите число:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("И еще одно:");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine($"Максимальное число: {Math.Max(x,y)}");
        }
    }
}
