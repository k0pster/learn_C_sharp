using System;
using System.Text; //Niezbędne do pracy StringBuildera.

namespace FormatingStringPreceisly
{
    class Program
    {
        static void Main(string[] args)
        {
            double earnings =25.1294;
            double d = 25.129239;
            double amount = 16000000;
            Console.WriteLine("Dzisiaj zarobiłem {0:C}", earnings); // C - podaje walutę w zależności od ustawień w systemie
            Console.WriteLine("Liczba {0:F3} oraz {1:F5} w różnym zaokrągleniu",d,d); // F - zaokrągla do liczb po przecinku
            Console.WriteLine("Liczba 16mln z oznaczeniem do sentych części zaokrąglając do jednego miejsca po przecinku {0:N1}", amount);
            Console.WriteLine($"Stan konta to {earnings:F2}"); //Znak dolara przed cudzysłowiem pozwala na interpolację zmiennej prosto z niego.

            //Poprzez StringBuilder możliwa jest fizyczna zmiana zmiennej string a nie tylko jej "sklonowanie"!
            StringBuilder builder = new StringBuilder("123");
            //metodą .Append() dodajemy możemy coś dodać na koniec stringa.
            builder.Append("456");
            Console.WriteLine(builder.ToString());//.ToString() wyświetla jako string.

            
            StringBuilder sb = new StringBuilder("michał");
            Console.WriteLine(sb);
            sb[0] = char.ToUpper(sb[0]);
            Console.WriteLine(sb.ToString());
        }
    }
}
