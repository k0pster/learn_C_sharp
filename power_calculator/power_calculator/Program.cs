using System;

namespace power_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę do potęgi:");
            int digit= Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Podaj dodatni wykładnik potęgi:");
            int power = Convert.ToInt16(Console.ReadLine());
            if (power > 0)
            {
                int power_result = 1;
                for (int i = 1; i <= power; i++)
                {
                    power_result = power_result * digit;
                    Console.WriteLine("{0} do {1} = {2}", digit, i, power_result);
                }    
            }
        }
    }
}
