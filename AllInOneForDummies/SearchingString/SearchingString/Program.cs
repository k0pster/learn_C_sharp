using System;

namespace SearchingString
{
    class Program
    {
        static void Main(string[] args)
        {
            string someString = "cheesburgers";
            //IndexOf() - wyszukuje pierwszy znak w stringu i zwraca
            //jego pozycję. Licząc od 0.
            int indexOfLetterS = someString.IndexOf('s');
            //LastIndexOf() - wyszukuje ostatni znak i zwraca jego pozycję.
            int indexOfLastLetterS = someString.LastIndexOf('s');

            //Contains() - zwraca True jeśli zawiera podany ciąg znaków.
            bool IsContain = someString.Contains("ee");
            Console.WriteLine(indexOfLetterS);
            Console.WriteLine(indexOfLastLetterS);
            Console.WriteLine(IsContain);
            //.Length wyświetla długość zmiennej.
            Console.WriteLine(someString.Length);
            //Substring() - wyświetla cześć strina w zakresie określonych
            //pozycji (arg.1 początek i arg.2 koniec).
            string sub = someString.Substring(0, someString.Length);
            Console.WriteLine(sub);



        }
    }
}
