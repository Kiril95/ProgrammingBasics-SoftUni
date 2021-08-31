using System;

namespace Energy_booster
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string sets = Console.ReadLine();
            int numSets = int.Parse(Console.ReadLine());

            double price = 0;

            switch (fruit)
            {
                case "Watermelon":
                    if (sets == "small")
                    {
                        price = 2 * 56.00;
                    }
                    else
                    {
                        price = 5 * 28.70;
                    }
                    break;
                case "Mango":
                    if (sets == "small")
                    {
                        price = 2 * 36.66;
                    }
                    else
                    {
                        price = 5 * 19.60;
                    }
                    break;
                case "Pineapple":
                    if (sets == "small")
                    {
                        price = 2 * 42.10;
                    }
                    else
                    {
                        price = 5 * 24.80;
                    }
                    break;
                case "Raspberry":
                    if (sets == "small")
                    {
                        price = 2 * 20.00;
                    }
                    else
                    {
                        price = 5 * 15.20;
                    }
                    break;
            }
            double total = price * numSets;

            if (total >= 400 && total <= 1000)
            {
                total *= 0.85;
            }
            else if (total > 1000)
            {
                total *= 0.5;
            }

            Console.WriteLine($"{total:f2} lv.");
        }    
    }
}
