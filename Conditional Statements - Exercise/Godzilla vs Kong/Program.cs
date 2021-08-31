using System;

namespace Godzilla_vs_Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double people = double.Parse(Console.ReadLine());
            double priceClothes = double.Parse(Console.ReadLine());

            double decoration = budget * 0.10;
            double costumes = people * priceClothes;
            
            if (people > 150)
            {
                costumes = costumes - (0.10 * costumes);
            }
            double total = decoration + costumes;
            double final = budget - total;
            
            if (total > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(final):f2} leva more.");
            }
            
            else if (total <= budget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {final:f2} leva left.");
            }

        }
    }
}
