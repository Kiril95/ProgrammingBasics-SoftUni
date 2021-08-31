using System;

namespace Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double greening = double.Parse(Console.ReadLine());
            
            double price = greening * 7.61;
            double discount = price * 0.18;
            double final = price - discount;

            Console.WriteLine($"The final prices is: {final} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");

        }
    }
}
