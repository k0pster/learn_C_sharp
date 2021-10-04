using System;

namespace BMI_calc
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight, height, bmi;
            Console.WriteLine("Kalkulator BMI");
            Console.WriteLine("Podaj wagę w kg: ");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj wzrost w cm");
            height = Double.Parse(Console.ReadLine());
            bmi = weight / (height * height / 10000);
            Console.WriteLine(bmi);
        }
    }
}
