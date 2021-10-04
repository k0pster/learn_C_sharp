using System;

namespace Arthmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y = 5; // x= - ; y=5
            x = ++y;    // x=6 - ; y=6
            x = y++;    // x=6 - ; y=7
            x = --y;    // x=6 - ; y=6
            x = y--;    // x=6 - ; y=5
            Console.WriteLine("y = {0}, y++ = {1}",y, y++) ;
            Console.WriteLine("y po wyświetleniu = {0}",y);
        }
    }
}
