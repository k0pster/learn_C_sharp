using System;

namespace Count_character
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            Console.WriteLine("Podaj Imie: ");
            text = Console.ReadLine();
            text = "Cześć " + text;
            Console.WriteLine(text);
            Console.WriteLine(text.Length);
        }
    }
}
