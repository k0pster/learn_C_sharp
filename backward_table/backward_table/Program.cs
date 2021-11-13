using System;

namespace backward_table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj ilość uczestników");
            int values = Convert.ToInt32(Console.ReadLine());
            int[] members = new int[values];
            for (int i = 0; i < members.Length; i++)
            {
                Console.WriteLine("podaj {0} dane:", i + 1);
                members[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] members_backward = new int[members.Length];

            for (int i = members.Length-1; i >= 0; i--)
            {
                members_backward[members.Length - i -1] = members[i];
            }
            foreach (int x in members_backward)
            {
                Console.WriteLine(x);
            }
        }
    }
}
