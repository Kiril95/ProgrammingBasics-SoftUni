using System;

namespace Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            double numChicken = double.Parse(Console.ReadLine()) * 10.35;
            double numFish = double.Parse(Console.ReadLine()) * 12.40;
            double numVegan = double.Parse(Console.ReadLine()) * 8.15;

            double total = numChicken + numFish + numVegan;
            double desert = total * 0.20;
            double final = total + desert + 2.50;

            Console.WriteLine($"Total: {final:f2}");

        }
    }
}
