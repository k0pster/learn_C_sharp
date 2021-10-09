using System;

namespace comp_per_stuednt_average
{
    class Program
    {
       static void Main(string[] args)
        {
            const int computers = 24;
            int students;
            double result;
            Console.WriteLine("Podaj ilość uczniów :");
            students = Convert.ToInt32(Console.ReadLine());
            result = (double)students / computers;
            Console.WriteLine(result);
        }
    }
}
