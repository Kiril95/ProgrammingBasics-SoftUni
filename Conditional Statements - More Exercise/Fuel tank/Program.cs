using System;

namespace Fuel_tank
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine().ToLower();
            double amount = double.Parse(Console.ReadLine());

            if (fuel == "diesel" || fuel == "gas" || fuel == "gasoline")
            {
                if (amount >= 25)
                {
                    Console.WriteLine($"You have enough {fuel}.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with {fuel}!");
                }                
            }
            else
            {
                Console.WriteLine($"Invalid fuel!");
            }
        }
    }
}
