using System;

namespace Movie_Destination
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            double days = double.Parse(Console.ReadLine());

            double sum = 0;

            if (destination == "Dubai")
            {
                if (season == "Winter")
                {
                    sum = 45000;
                }
                else if (season == "Summer")
                {
                    sum = 40000;
                }               
                sum = (sum * days) * 0.70;             
            }
            else if (destination == "Sofia")
            {
                if (season == "Winter")
                {
                    sum = 17000;
                }
                else if (season == "Summer")
                {
                    sum = 12500;
                }
                sum = (sum * days) * 1.25;
            }
            else if (destination == "London")
            {
                if (season == "Winter")
                {
                    sum = 24000;
                }
                else if (season == "Summer")
                {
                    sum = 20250;
                }
                sum = (sum * days);
            }
            if (sum <= budget)
            {
                Console.WriteLine($"The budget for the movie is enough! We have " +
                    $"{Math.Abs(budget - sum):f2} leva left!");
            }
            else
            {
                Console.WriteLine($"The director needs {Math.Abs(budget - sum):f2} leva more!");
            }              
        }
    }
}