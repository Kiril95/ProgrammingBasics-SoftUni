using System;

namespace Toy_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceTrip = double.Parse(Console.ReadLine());    
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double allToys = puzzles * 2.60 + dolls * 3 + bears * 4.10 + minions * 8.20 + trucks * 2;
            double toysCount = puzzles + dolls + bears + minions + trucks;
            if (toysCount >= 50)
            {
                double discount = allToys * 0.25;
                double endPrice = allToys - discount;
                double rent = endPrice * 0.10;
                double profit = endPrice - rent;
                double leftMoney = profit - priceTrip;
                Console.WriteLine($"Yes! {leftMoney:f2} lv left.");
            }
            else if (toysCount < 50)
            {
                double rent2 = allToys * 0.10;
                double profit2 = allToys - rent2;
                double leftMoney2 = priceTrip - profit2;                            
                Console.WriteLine($"Not enough money! {leftMoney2:f2} lv needed.");
            }
        }
    }
}
