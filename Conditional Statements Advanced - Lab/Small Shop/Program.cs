using System;

namespace Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine().ToLower();
            var town = Console.ReadLine().ToLower();
            var price = double.Parse(Console.ReadLine());

            if (town == "sofia")
            {
                if (product == "coffee")
                    Console.WriteLine(price * 0.50);
                else if (product == "water")
                    Console.WriteLine(price * 0.80);
                else if (product == "beer")
                    Console.WriteLine(1.20 * price);
                else if (product == "sweets")
                    Console.WriteLine(price * 1.45);
                else if (product == "peanuts")
                    Console.WriteLine(price * 1.60);
            }
            else if (town == "plovdiv")
            {
                if (product == "coffee")
                    Console.WriteLine(price * 0.40);
                else if (product == "water")
                    Console.WriteLine(price * 0.70);
                else if (product == "beer")
                    Console.WriteLine(price * 1.15);
                else if (product == "sweets")
                    Console.WriteLine(price * 1.30);
                else if (product == "peanuts")
                    Console.WriteLine(price * 1.50);
            }
            else if (town == "varna")
            {
                if (product == "coffee")
                    Console.WriteLine(price * 0.45);
                else if (product == "water")
                    Console.WriteLine(price * 0.70);
                else if (product == "beer")
                    Console.WriteLine(price * 1.10);
                else if (product == "sweets")
                    Console.WriteLine(price * 1.35);
                else if (product == "peanuts")
                    Console.WriteLine(price * 1.55);
            }

        }
    }
}
