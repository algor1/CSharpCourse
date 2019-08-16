using System;
using System.Text;

namespace dz
{
    class Program
    {
        static void Main(string[] args)
        {
            Dz1 d = new Dz1();
            //d.Dz1_1();
            //d.HeronTriangleArea();
            d.UserProfile();
            Console.ReadKey();
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
            
        }
        public void HeronTriangleArea()
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
        private bool checkTiangleData(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0 || a + b <= c || a + c <= b || b + c <= a)
            {
                Console.WriteLine("Такого треугольника не может быть");
                return false;
            }
            return true;


        }
        public void UserProfile()
        {
            StringBuilder profile = new StringBuilder("Your profile:");
            profile.AppendLine();
            Console.WriteLine("ВВедите фамилию");
            profile.Append("Full Name: ");
            profile.Append(Console.ReadLine());
            Console.WriteLine("ВВедите имя");
            profile.AppendLine(", " +Console.ReadLine());

            Console.WriteLine("ВВедите возраст");
            profile.Append("Age: ");
            int age = int.Parse(Console.ReadLine());
            profile.AppendLine(age.ToString());
            Console.WriteLine("ВВедите вес(кг)");
            profile.Append("Weight: ");
            double weight = double.Parse(Console.ReadLine());
            profile.AppendLine(weight.ToString());
            Console.WriteLine("Введите рост(м)");
            profile.Append("Height: ");
            double height = double.Parse(Console.ReadLine());
            profile.AppendLine(height.ToString());
            double imt = (weight / (height * height));
            profile.AppendLine("Body Mass Index: " + imt.ToString());

            Console.WriteLine(profile);
           

        }

    }
}
