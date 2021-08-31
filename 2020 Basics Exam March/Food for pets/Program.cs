using System;

namespace Food_for_pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double totalAmount = double.Parse(Console.ReadLine());

            var totalBiscuits = 0.0;
            var prFood = 0.0;
            var prDog = 0.0;
            var PrCat = 0.0;

            for (int i = 1; i <= days; i++)
            {
                int dogFood = int.Parse(Console.ReadLine());
                int catFood = int.Parse(Console.ReadLine());

                prDog += dogFood;
                PrCat += catFood;

                if (i % 3 == 0)
                {
                    double biscuits = (dogFood + catFood) * 0.10;
                    totalBiscuits += biscuits;
                }
            }
            double totalFood = prDog + PrCat;
            prFood = (totalFood / totalAmount) * 100;
            prDog = (prDog / totalFood) * 100;
            PrCat = (PrCat / totalFood) * 100;

            Console.WriteLine($"Total eaten biscuits: {Math.Round(totalBiscuits)}gr.");
            Console.WriteLine($"{prFood:f2}% of the food has been eaten.");
            Console.WriteLine($"{prDog:f2}% eaten from the dog.");
            Console.WriteLine($"{PrCat:f2}% eaten from the cat.");
        }
    }
}
