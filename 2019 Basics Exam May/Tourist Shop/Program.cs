using System;

namespace Tourist_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string command = Console.ReadLine(); 
            int counter = 0;
            double sum = 0;

            while (command != "Stop")
            {              
                double product = double.Parse(Console.ReadLine());
                counter++;
                if (counter % 3 == 0)
                {
                    product /= 2;
                }
                if (budget < product)
                {
                    Console.WriteLine("You don't have enough money!");
                    Console.WriteLine($"You need {product - budget:f2} leva!");
                    return;
                }
                budget -= product;
                sum += product;              
                command = Console.ReadLine();
            }
            Console.WriteLine($"You bought {counter} products for {sum:f2} leva.");

        }
    }
}
