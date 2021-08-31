using System;

namespace Fishing_boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fisherman = int.Parse(Console.ReadLine());

            double price = 0;
            switch (season)
            {
                case "Spring":
                    price = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    price = 4200;
                    break;
                case "Winter":
                    price = 2600;
                    break;
            }
            
            if (fisherman <= 6)
            {
                price *= 0.90;
            }
            else if (fisherman >= 7 && fisherman <= 11)
            {
                price *= 0.85;
            }
            else if (fisherman >= 12)
            {
                price *= 0.75;
            }
            if (fisherman % 2 == 0 && season != "Autumn")
            {
                price *= 0.95;
            }
            double moneyLeft = budget - price;

            if (budget >= price)
            {
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(moneyLeft):f2} leva.");
            }
           
        }
    }
}
