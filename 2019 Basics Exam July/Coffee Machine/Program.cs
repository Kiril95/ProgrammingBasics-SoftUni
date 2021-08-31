using System;

namespace Coffee_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string sugar = Console.ReadLine();
            int numDrinks = int.Parse(Console.ReadLine());
            double sum = 0;
            double discount = 0;
            
            if (sugar == "Without")
            {
                if (drink == "Espresso")
                {
                    sum = numDrinks * 0.90;
                    sum *= 0.65;
                    if (numDrinks >= 5)
                    {
                        discount = sum * 0.25;
                        sum -= discount;
                    }
                }
                else if (drink == "Cappuccino")
                {
                    sum = numDrinks * 1;
                    sum *= 0.65;                  
                }
                else if (drink == "Tea")
                {
                    sum = numDrinks * 0.50;
                    sum *= 0.65;
                }
            }
            else if (sugar == "Normal")
            {
                if (drink == "Espresso")
                {
                    sum = numDrinks * 1;
                    if (numDrinks >= 5)
                    {
                        discount = sum * 0.25;
                        sum -= discount;
                    }
                }
                else if (drink == "Cappuccino")
                {
                    sum = numDrinks * 1.20;
                }
                else if (drink == "Tea")
                {
                    sum = numDrinks * 0.60;
                }
            }
            else if (sugar == "Extra")
            {
                if (drink == "Espresso")
                {
                    sum = numDrinks * 1.20;
                    if (numDrinks >= 5)
                    {
                        discount = sum * 0.25;
                        sum -= discount;
                    }
                }
                else if (drink == "Cappuccino")
                {
                    sum = numDrinks * 1.60;
                }
                else if (drink == "Tea")
                {
                    sum = numDrinks * 0.70;
                }
            }
            if (sum >= 15)
            {
                sum *= 0.80;
            }
            Console.WriteLine($"You bought {numDrinks} cups of {drink} for {sum:f2} lv.");
        }
        
    }
}
