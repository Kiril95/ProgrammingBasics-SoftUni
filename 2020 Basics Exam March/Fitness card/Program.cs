using System;

namespace Fitness_card
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            double age = double.Parse(Console.ReadLine());
            string sport = Console.ReadLine();

            double price = 0;

            if (gender == "m" && sport == "Gym") price = 42;

            else if (gender == "m" && sport == "Boxing") price = 41;

            else if (gender == "m" && sport == "Yoga") price = 45;

            else if (gender == "m" && sport == "Zumba") price = 34;

            else if (gender == "m" && sport == "Dances") price = 51;

            else if (gender == "m" && sport == "Pilates") price = 39;

            else if (gender == "f" && sport == "Gym") price = 35;

            else if (gender == "f" && sport == "Boxing") price = 37;

            else if (gender == "f" && sport == "Yoga") price = 42;

            else if (gender == "f" && sport == "Zumba") price = 31;

            else if (gender == "f" && sport == "Dances") price = 53;

            else if (gender == "f" && sport == "Pilates") price = 37;

            if (age <= 19)
            {
                price *= 0.80;
            }

            if (price <= money)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else if (price > money)
            {
                double neededMoney = price - money;
                Console.WriteLine($"You don't have enough money! You need ${neededMoney:f2} more.");
            }
        }
    }
}
