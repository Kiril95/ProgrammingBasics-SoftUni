using System;

namespace Safari
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double litersFuel = double.Parse(Console.ReadLine()) * 2.10;
            string day = Console.ReadLine();
            const int GUIDE = 100;

            double total = litersFuel + GUIDE;
            if (day == "Sunday")
            {
                total *= 0.80;
            }
            else if (day == "Saturday")
            {
                total *= 0.90;
            }

            if (budget >= total)
            {
                Console.WriteLine($"Safari time! Money left: {budget - total:f2} lv.");
            }
            else
            {
                Console.WriteLine($"Not enough money! Money needed: {Math.Abs(budget - total):f2} lv.");
            }

        }
    }
}
