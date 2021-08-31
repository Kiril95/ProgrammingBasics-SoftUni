using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string holiday = string.Empty;
            string place = string.Empty;

            if (budget <= 100)
            {
                holiday = "Bulgaria";
                if (season == "summer")
                {
                    budget *= 0.30;
                    place = "Camp";
                }
                else if (season == "winter")
                {
                    budget *= 0.70;
                    place = "Hotel";
                }
            }
            else if (budget <= 1000)
            {
                holiday = "Balkans";
                if (season == "summer")
                {
                    budget *= 0.40;
                    place = "Camp";
                }
                else if (season == "winter")
                {
                    budget *= 0.80;
                    place = "Hotel";
                }
            }
            else if (budget > 1000)
            {
                holiday = "Europe";
                budget *= 0.90;
                place = "Hotel";
            }
            Console.WriteLine($"Somewhere in {holiday}");
            Console.WriteLine($"{place} - {budget:f2}");
        }
    }
}
