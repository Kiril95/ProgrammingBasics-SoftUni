using System;

namespace Travel_Agency
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            string package = Console.ReadLine();
            string VIP = Console.ReadLine();
            double days = double.Parse(Console.ReadLine());
            double sum = 0;
            double discount = 0;

            if (days > 7)
            {
                days -= 1;
            }            
            if (days < 1)
            {
                Console.WriteLine("Days must be positive number!");
                return;
            }
            if (town == "Bansko" || town == "Borovets" || town == "Varna" || town == "Burgas")
            {
                if (package == "noEquipment")
                {
                    sum = 80;                    
                    if (VIP == "yes")
                    {
                        sum *= 0.95;
                    }
                    sum *= days;
                }
                else if (package == "withEquipment")
                {
                    sum = 100;
                    if (VIP == "yes")
                    {
                        sum *= 0.9;
                    }
                    sum *= days;
                }
                else if (package == "noBreakfast")
                {
                    sum = 100;
                    if (VIP == "yes")
                    {
                        sum *= 0.93;
                    }
                    sum *= days;
                }
                else if (package == "withBreakfast")
                {
                    sum = 130;
                    if (VIP == "yes")
                    {
                        sum *= 0.88;
                    }
                    sum *= days;
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
                return;
            }
            Console.WriteLine($"The price is {sum:f2}lv! Have a nice time!");

        }
    }
}
