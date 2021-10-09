using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double result;
            Console.WriteLine("Wybierz działanie: +, -, /, *");
            string operators = Console.ReadLine();
            Console.WriteLine("Podaj liczbę 1:");
            double digit1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę 2:");
            double digit2 = double.Parse(Console.ReadLine());
            switch (operators)
            {
                case "+":
                    result = digit1 + digit2;
                    Console.WriteLine(result);
                    break;
                case "-":
                    result = digit1 - digit2;
                    Console.WriteLine(result);
                    break;
                case "/":
                    result = digit1 / digit2;
                    Console.WriteLine(result);
                    break;
                case "*":
                    result = digit1 * digit2;
                    Console.WriteLine(result);
                    break;
                default:
                    Console.WriteLine("Wybrano zły znak");
                    break;
            }
        }
    }
}
