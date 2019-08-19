using System;
using System.Collections.Generic;
using System.Text;


namespace dz
{
    class Dz4
    {
        public void RomanNumeralsParser()
        {
            var digits = new Dictionary<char, int>()
            {
                { 'I',1},
                { 'V',5},
                { 'X',10},
                { 'L',50},
                {'C',100 },
                {'D',500 },
                {'M',1000 }
            };
            Console.WriteLine("Enter Roman number");
            string roman=Console.ReadLine();
            int sum =0;
            for (int i = roman.Length-1; i>0; i--)
            {
                if (i == 0)
                {
                    sum += digits[roman[i]];
                    break;
                }
                
                if (digits[roman[i]]> digits[roman[i-1]])
                {
                    sum -= digits[roman[i]];
                }
                else
                {
                    sum += digits[roman[i]];
                }
            }
            sum += digits[roman[0]];
            Console.WriteLine($"In arabic digits. it is {sum}");

        }
    }
}
