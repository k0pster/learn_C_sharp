using System;

namespace delta_calc
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, result;
            Console.WriteLine("Kalulator delty");
            Console.WriteLine("ax2 + bx + c = 0");
            Console.WriteLine("Podaj a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj c: ");
            c = Convert.ToDouble(Console.ReadLine());
            result = (b * b) - 4 * a * c;
            Console.WriteLine("Wynik: {0}", result);
            
        }
    }
}
