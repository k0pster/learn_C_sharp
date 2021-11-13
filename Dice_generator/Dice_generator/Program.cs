using System;

namespace Dice_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generator kości do gry");
            Console.WriteLine("Podaj ilość ścianek kostki");
            int diceSize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ile razy rzucasz?");
            int throwsAmount = Convert.ToInt32(Console.ReadLine());
            int[] throws = new int[throwsAmount];
            Random dice = new Random();
            int criticalHitCounter = 0;

            for (int i = 0; i < throwsAmount; i++)
            {
                throws[i] = dice.Next(1, diceSize + 1);
                if (throws[i]==diceSize)
                {
                    criticalHitCounter++;
                }
            }
            foreach (int shot in throws)
            {
                Console.WriteLine("[ {0} ]",shot);
                if (shot == diceSize)
                {
                    Console.WriteLine("BANG - trafienie krytyczne!"); 
                }
            }
            Console.WriteLine("Wartość krytyczna {0} wyrzucona została {1} razy", diceSize, criticalHitCounter);
            Console.WriteLine(throws.Length);
        }
    }
}
