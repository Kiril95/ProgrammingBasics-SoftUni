using System;

namespace Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double episode = double.Parse(Console.ReadLine());
            double breakk = double.Parse(Console.ReadLine());

            double lunch = breakk / 8;
            double rest = breakk / 4;
            double total = breakk - lunch - rest;

            if (total >= episode)
            {
                Console.WriteLine($"You have enough time to watch {name} and left with " +
                    $"{Math.Ceiling(Math.Abs(episode - total))} minutes free time.");
            }
            else
            {            
                Console.WriteLine($"You don't have enough time to watch {name}, " +
                    $"you need {Math.Ceiling(episode - total)} more minutes.");
            }
      
        }
    }
}
