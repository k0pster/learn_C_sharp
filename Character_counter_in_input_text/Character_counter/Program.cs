using System;

namespace Character_counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfChar = 0;
            Console.WriteLine("Licznik znaków w tekście");
            Console.WriteLine("Wpisz tekst");
            string text = Console.ReadLine();
            Console.WriteLine("Jaki znak zliczać?");
            char variable = Convert.ToChar(Console.ReadLine());
            foreach (char letter in text)
            {
                if (letter == variable)
                {
                    numberOfChar++;
                }
            }
            Console.WriteLine("Zdanie posiada {1} znaków. Litera '{2}' wystąpiła {0} razy",numberOfChar,text.Length,variable);
        }
    }
}
