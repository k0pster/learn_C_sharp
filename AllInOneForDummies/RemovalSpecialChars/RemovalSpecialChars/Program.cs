using System;

namespace RemovalSpecialChars
{
    class Program
    {
        //Tworzymy funkcję pobierająca string oraz tablicę znaków char, które mają być pominięte.
        //Używamy .Split(), żeby podzielić cały string na pojedyńcze elementy i umieścić je w nowej tablicy stringów
        //Następnie wypełniamy pusty string łącząc funkcją .Concat() każdy element złączonej tablicy stringów.
        public static string RemovalSpecialChars(string input, char[] targets)
        {
            string[] subStrings = input.Split(targets);

            string output = "";

            foreach (string subString in subStrings)
            {
                output = String.Concat(output, subString);
            }
            return output;
        }
        static void Main(string[] args)
        {
            //Uruchamiamy funkcję dla pobranego przez użytkownika stringu z usunięciem białych znaków.
            Console.WriteLine("Podaj string: ");
            string inputString = Console.ReadLine();
            char[] whiteSpace = { ' ', '\n','\t' };
            Console.WriteLine(RemovalSpecialChars(inputString, whiteSpace));
        }
    }
}
