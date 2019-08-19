using System;

namespace dz
{
        public class Dz3
    {
        public void Fibonachi()
        {
            Console.WriteLine("How many fibonachi numbers shoul i calculate? :");
            int number = int.Parse(Console.ReadLine());
            int[] fionachi = new int[number];

            if (number >=1)
            {
                fionachi[0] = 1;
            }

            if (number >= 2)
            {
                fionachi[1] = 1;
            }

            for (int i = 2; i < number; i++)
            {
                fionachi[i] = fionachi[i - 1] + fionachi[i - 2];
            }

            for (int i = 0; i < number; i++)
            {
                Console.Write(fionachi[i]+" ");
            }
        }
        public void Mean()
        {
            Console.WriteLine("Введите несколько целых чисел, но не более 10. Для прерывания последовательности введите 0" );
            int sum = 0;
            int number = 0;
            double mean = 0;
            for (int i = 0; i < 10; i++)
            {
               
                number = int.Parse(Console.ReadLine());
                if (number == 0)
                {
                    break;
                }
                sum += number;
                mean = (double)sum / ((double)i + 1);

            }
            Console.WriteLine($"Среднее значение = {mean}");

        }
        public void Factorial()
        {
            Console.WriteLine("Calulate factorial of (enter number) :");
            int value = 1;
            int number = int.Parse(Console.ReadLine());
            if (number==0)
            {
                value = 1;
            }
            for (int i = 1; i <= number; i++)
            {
                value *= i;
            }
            Console.WriteLine($"{number}! = {value}");
        }
    }
}
