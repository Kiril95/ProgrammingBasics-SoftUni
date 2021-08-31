using System;

namespace Cat_walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int minWalks = int.Parse(Console.ReadLine());
            int numberWalks = int.Parse(Console.ReadLine());
            int calories = int.Parse(Console.ReadLine());

            double totalWalk = minWalks * numberWalks;
            double caloriesBurned = totalWalk * 5;
            calories /= 2;

            if (caloriesBurned >= calories)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: " +
                    $"{caloriesBurned}.");
            }
            else if (caloriesBurned < calories)
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: " +
                    $"{caloriesBurned}.");
            }

        }
    }
}
