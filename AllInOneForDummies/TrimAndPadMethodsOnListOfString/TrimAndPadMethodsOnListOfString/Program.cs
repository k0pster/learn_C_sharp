using System;
using System.Collections.Generic; //Musimy użyć żeby ich użyć.

namespace TrimAndPadMethodsOnListOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> {"Michał   ","   Ewka",
                "Marcinek  ","Jogi    ","   Bubu"};
            Console.WriteLine("Imiona są różnej długości");

            foreach(string s in names)
            {
                Console.WriteLine("To jest imię : " + s + " na początku");
            }

            //Bedziemy dodawać listę stringów do nowo stworzonej listy,
            //którą zeedutujemy.
            List<string> AlignStrings = new List<string>();

            //Pętlą For czyścimy niechciane spacje w pozycjach z listy names.
            //Do przechodzenia po pozycjach listy użyjemy licznika .Count
            //Do dodawania elementów do nowej listy użyjemy .Add()

            for (int l = 0; l < names.Count; l++)
            {
                string trimmedName = names[l].Trim();
                AlignStrings.Add(trimmedName);
            }

            //Znajdujemy najdłuższy element listy przy pomocy pętli foreach
            int maxLength = 0;
            foreach (string s in AlignStrings)
            {
                if (s.Length > maxLength) 
                {
                    maxLength = s.Length;
                }                      
            }

            //Kiedy znamy maksymalną długość elementów używamy PadRight()
            //To schludnej prezentacji wyników
            for (int l = 0; l < AlignStrings.Count; l++)
            {
                AlignStrings[l] = AlignStrings[l].PadRight(maxLength + 1);
            }

            //Wyświetlamy zeedytowaną listę string AllignStrings
            Console.WriteLine("Imiona są tej samej długości oraz wyrówn" +
                "ane do lewej");
            foreach (string s in AlignStrings)
            {
                Console.WriteLine("To jest imię: " + s + " po zmianach");
            }
        }
    }
}
