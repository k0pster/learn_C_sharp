using System;

namespace find_max_in_table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ilość danych");
            int values = Convert.ToInt32(Console.ReadLine());
            int [] table = new int[values];
            for (int i = 0; i < table.Length; i++)
            {
                Console.WriteLine("Podaj {0} daną:",i+1);
                table[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = table[0];
            for (int i = 0; i < table.Length; i++)
            {
                if (table[i]>max)
                {
                    max = table[i];
                }
            }
            Console.WriteLine("Największa zmienna wynnosi {0}", max);
        }
    }
}
