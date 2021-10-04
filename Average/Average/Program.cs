using System;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            const int computers = 24;
            int students;
            double result;
            Console.WriteLine("Podaj liczbę studentów :");
            students = Convert.ToInt32((Console.ReadLine()));
            result = (double)students / computers;
            Console.WriteLine(result);
        }
    }
}
