using System;

namespace New_house
{
    class Program
    {
        static void Main(string[] args)
        {            
            string flower = Console.ReadLine();
            double flowerCount = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            
            double price = 0;
            double roses = 5;
            double dahlias = 3.80;
            double tulips = 2.80;
            double narcissus = 3;
            double gladiolus = 2.50;

            if (flower == "Roses") 
            {
                price = flowerCount * roses;
                if (flowerCount > 80)
                {
                    price *= 0.9;
                }
            }
            else if (flower == "Dahlias") 
            {
                price = flowerCount * dahlias;
                if (flowerCount > 90)
                {
                    price *= 0.85;
                }
            }           
            else if (flower == "Tulips") 
            {
                price = flowerCount * tulips;
                if (flowerCount > 80)
                {
                    price *= 0.85;
                }
            }
            else if (flower == "Narcissus") 
            {
                price = flowerCount * narcissus;
                if (flowerCount < 120)
                {
                    price *= 1.15;
                }
            }
            else if (flower == "Gladiolus") 
            {
                price = flowerCount * gladiolus;
                if (flowerCount < 80)
                {
                    price *= 1.20;
                }
            }

            double moneyLeft = budget - price;
            if (moneyLeft >= 0)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flower} " +
                    $"and {moneyLeft:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {Math.Abs(moneyLeft):f2} leva more.");
            }

        }
    }
}
