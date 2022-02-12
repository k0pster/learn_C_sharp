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
            for ( ; ; )
            {
                Console.WriteLine("Podaj string");
                string line = Console.ReadLine();

                string[] terms = { "EXIT", "QUIT", "quit","exit"};
                bool quitting = false;

                foreach (string term in terms)
                {
                    //Przerywamy jeśli jest dopasowanie,
                    if (String.Compare(line, term) == 0)
                    {
                        quitting = true;
                    }
                }
                if (quitting == true)
                {
                      break;
                }
                    //jeśli nie łączymy pobrane linie w zdanie.
                    sentence = String.Concat(sentence, line);

                    Console.WriteLine("\nWstawiłeś: " + sentence);
            }

                Console.WriteLine("\nCałe zdanie: \n" + sentence);
            }
        }
    }
