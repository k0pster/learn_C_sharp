using System;

namespace Reverse_table
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] table1 = new int[] { 10, 11, 12, 13, 14 };
            int[] reversetable1 = new int[table1.Length];
            for (int i = table1.Length - 1; i >= 0; i--)
            {
                reversetable1[table1.Length - i - 1] = table1[i];
            }
            for (int i = 0; i < reversetable1.Length; i++)
            {
                Console.WriteLine(reversetable1[i]);
            }
        }
    }
}
