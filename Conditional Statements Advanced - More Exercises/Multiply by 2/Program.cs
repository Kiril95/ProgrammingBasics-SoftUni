using System;

namespace Multiply_by_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
           
            while (number >= 0)
            {
                number *= 2;
                Console.WriteLine($"Result: {number:f2}");
                number = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Negative number!");

           //for (int i = 1; i > 0; i++)
           //{
           //    double number = double.Parse(Console.ReadLine());
           //  
           //    if (number < 0)
           //    {
           //        Console.WriteLine("Negative number!");
           //    }
           //    else
           //    {
           //        number *= 2;
           //        Console.WriteLine($"Result: {number:f2}");
           //    }
           //}
        }
                                       
    }
}
