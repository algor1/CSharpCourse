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
    }
}
