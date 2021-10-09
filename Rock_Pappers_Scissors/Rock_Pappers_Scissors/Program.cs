using System;

namespace Rock_Pappers_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int player1, player2, games, counter = 0;

            Console.WriteLine("Ile razy chcesz grać? :");
            games = int.Parse(Console.ReadLine());

            while(counter != games)
            { 
            Console.WriteLine("Gracz 1: Wybierz\n1 - Papier\n2 - Kamień\n3 - Nożyce");
            player1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Gracz 2: Wybierz\n1 - Papier\n2 - Kamień\n3 - Nożyce");
            player2 = int.Parse(Console.ReadLine());

            switch (player1)
            {
                case 1:
                    if (player2 != 1)
                    {
                        if (player2 == 2)
                        {
                            Console.WriteLine("Gracz 1 - Wygrana!");
                        }
                        if (player2 == 3)
                        {
                            Console.WriteLine("Gracz 2 - Wygrana!");
                        }
                        if (player2 > 3)
                        {
                            Console.WriteLine("Nieznana Wartość");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Remis");
                    }
                        counter++;
                    break; 
            
                case 2:
                    if (player2 != 2)
                    {
                        if (player2 == 3)
                        {
                            Console.WriteLine("Gracz 1 - Wygrana!");
                        }
                        if (player2 == 1)
                        {
                            Console.WriteLine("Gracz 2 - Wygrana!");
                        }
                        if (player2 > 3)
                        {
                            Console.WriteLine("Nieznana Wartość");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Remis");
                    }
                        counter++;
                    break;

                case 3:
                    if (player2 != 3)
                    {
                        if (player2 == 1)
                        {
                            Console.WriteLine("Gracz 1 - Wygrana!");
                        }
                        if (player2 == 2)
                        {
                            Console.WriteLine("Gracz 2 - Wygrana!");
                        }
                        if (player2 > 3)
                        {
                            Console.WriteLine("Nieznana Wartość");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Remis");
                    }
                        counter++;
                    break;
                default:
                    Console.WriteLine("Nieznana Wartość");
                    break;
            }
            }
        }
    }
}
