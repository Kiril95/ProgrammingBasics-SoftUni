using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double videoCard = double.Parse(Console.ReadLine());
            double processor = double.Parse(Console.ReadLine());
            double ram = double.Parse(Console.ReadLine());

            double one = videoCard * 250;
            double two = one * 0.35 * processor;
            double three = one * 0.10 * ram;
            double total = one + two + three;

            if (videoCard > processor)
            {
                total *= 0.85;
            }
            if (total <= budget)
            {
                Console.WriteLine($"You have {budget - total:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(budget - total):f2} leva more!");
            }
        }
    }
}
