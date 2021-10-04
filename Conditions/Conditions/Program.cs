using System;

namespace Conditions
{
    class Program
    {
        static void Main (string[] args)
        {
        double age, PLN;
        bool cinema;
        Console.WriteLine("Podaj wiek: ");
        age =double.Parse(Console.ReadLine());
        Console.WriteLine("Ile masz kasy?");
        PLN=double.Parse(Console.ReadLine());
        cinema = (age >= 18 && PLN > 20);
        Console.WriteLine(cinema);
        }
    }
}





