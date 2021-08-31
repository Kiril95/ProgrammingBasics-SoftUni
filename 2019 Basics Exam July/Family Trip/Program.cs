using System;

namespace Family_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double nights = double.Parse(Console.ReadLine());
            double priceNights = double.Parse(Console.ReadLine());
            double expenses = double.Parse(Console.ReadLine());
            double discount = 0;
            double price = 0;
            double tax = 0;
            double sum = 0;
            double final = 0;
            if (nights > 7)
            {
                discount = priceNights * 0.95;
                price = discount * nights;
                tax = (budget * expenses) / 100;
                sum = price + tax;
                final = sum - budget;
            }
            else
            {
                price = priceNights * nights;
                tax = (budget * expenses) / 100;
                sum = price + tax;
                final = sum - budget;
            }
             
            if (sum <= budget)
            {
                Console.WriteLine($"Ivanovi will be left with {Math.Abs(final):f2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{final:f2} leva needed.");
            }

        }
    }
}
