using System;

namespace Compare
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program ma łączyć ze sobą podane przeż użytkownika zdania,
            //do momentu wychwycenia słów kluczowych EXIT, QUIT
            Console.WriteLine("Każde zdanie będzie pobierane dopóki "
                + "nie napiszesz słów kluczowych EXIT lub QUIT");
            string sentence = "";
            for (; ; )
            {
                Console.WriteLine("Podaj string");
                string line = Console.ReadLine();
                //poprzez 3 argumentową opcję funkcji Compare
                //wielkość liter w słowie kluczowym nie ma znaczenia.

                if ((String.Compare("exit", line, true)) == 0 || 
                    (String.Compare("quit",line, true) == 0))
                {
                    break;
                }
                sentence = String.Concat(sentence, line);

                Console.WriteLine("\nWstawiłeś: " + sentence);
            }

            Console.WriteLine("\nCałe zdanie: \n" + sentence);
        }
    }
}
