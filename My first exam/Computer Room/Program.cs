using System;

namespace Computer_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double hoursSpent = double.Parse(Console.ReadLine());
            double numPeople = double.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();

            double total = 0;
            double pricePerPerson = 0;

            if (month == "march" || month == "april" || month == "may")
            {
                if (timeOfDay == "day")
                {
                    pricePerPerson = 10.50;
                    if (numPeople >= 4)
                    {
                        pricePerPerson *= 0.90;
                    }
                    if (hoursSpent >= 5)
                    {
                        pricePerPerson *= 0.50;
                    }
                }
                else if (timeOfDay == "night")
                {
                    pricePerPerson = 8.40;
                    if (numPeople >= 4)
                    {
                        pricePerPerson *= 0.90;
                    }
                    if (hoursSpent >= 5)
                    {
                        pricePerPerson *= 0.50;
                    }
                }
                total = (pricePerPerson * hoursSpent) * numPeople;
            }
            else if (month == "june" || month == "july" || month == "august")
            {
                if (timeOfDay == "day")
                {
                    pricePerPerson = 12.60;
                    if (numPeople >= 4)
                    {
                        pricePerPerson *= 0.90;
                    }
                    if (hoursSpent >= 5)
                    {
                        pricePerPerson *= 0.50;
                    }
                }
                else if (timeOfDay == "night")
                {
                    pricePerPerson = 10.20;
                    if (numPeople >= 4)
                    {
                        pricePerPerson *= 0.90;
                    }
                    if (hoursSpent >= 5)
                    {
                        pricePerPerson *= 0.50;
                    }
                }
                total = (pricePerPerson * hoursSpent) * numPeople;
            }
            Console.WriteLine($"Price per person for one hour: {pricePerPerson:f2}");
            Console.WriteLine($"Total cost of the visit: {total:f2}");

        }
    }
}
