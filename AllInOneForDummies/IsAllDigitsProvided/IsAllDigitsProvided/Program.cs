using System;

namespace IsAllDigitsProvided
{
    
    class Program
    {
        //Funkcji IsAllDigits() pobiera string i sprawdza, czy
        //jest string jest liczbą czy nie znak po znaku za pomocą
        //Char.IsDigit() w pętli for, dopusczająć jednak pierwszy
        //ujemny znak.
        static bool IsAllDigits(string raw)
        {
            string s = raw.Trim();
            if (s.Length == 0) return false;

            for (int index = 0; index < s.Length; index++)
            {
                if (s[index] == '-' && index == 0) continue;

                if (Char.IsDigit(s[index]) == false) return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę: ");
            string s = Console.ReadLine();
            //Wywołuje funkcję dla pobranego stringa i wyświetlam odpowiedni
            //komunikat.
            if (!IsAllDigits(s))
            {
                Console.WriteLine("To nie jest liczba!");
            }
            else
            {
                int number = Int32.Parse(s);
                Console.WriteLine("Liczba to: {0}", number);
            }
        }
    }
}

