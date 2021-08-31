using System;

namespace Cat_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCats = int.Parse(Console.ReadLine());
            int littleCats = 0;
            int bigCats = 0;
            int giantCats = 0;
            double priceFood = 0;
            double final = 0;
            
            for (int i = 0; i < numCats; i++)
            {
                double catFood = double.Parse(Console.ReadLine());
                priceFood += catFood;
                if (catFood >= 100 && catFood < 200)
                {
                    littleCats++;
                }
                else if (catFood >= 200 && catFood < 300)
                {
                    bigCats++;
                }
                else if (catFood >= 300 && catFood < 400)
                {
                    giantCats++;
                }
            }
            priceFood /= 1000;
            final = priceFood * 12.45;
            
            Console.WriteLine($"Group 1: {littleCats} cats.");
            Console.WriteLine($"Group 2: {bigCats} cats.");
            Console.WriteLine($"Group 3: {giantCats} cats.");
            Console.WriteLine($"Price for food per day: {final:f2} lv.");
        }
    }
}
