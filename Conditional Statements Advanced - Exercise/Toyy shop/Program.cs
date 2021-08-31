using System;

namespace Toyy_shop
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
            
            double allToys = (puzzles * 2.60) + (dolls * 3) + (bears * 4.10) + (minions * 8.20) + (trucks * 2);
            double toysCount = puzzles + dolls + bears + minions + trucks;
            if (toysCount >= 50)
            {
                allToys *= 0.75;                                            
            }
            double rent = allToys * 0.9;
            
            if (rent >= priceTrip)
            {
                double final = rent - priceTrip;
                Console.WriteLine($"Yes! {final:f2} lv left.");
            }
            else
            {
                double final2 = priceTrip - rent;
                Console.WriteLine($"Not enough money! {final2:f2} lv needed.");
            }
        }
    }
}
