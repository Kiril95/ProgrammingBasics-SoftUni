using System;

namespace Ski_trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            string typeRoom = Console.ReadLine();
            string rating = Console.ReadLine();

            if (days >= 10 && days <= 15)
            {
                if (typeRoom == "apartment" && rating == "positive")
                {
                    double nights = (days - 1) * 25.00;
                    double discount = nights * 0.65;
                    double grade = discount * 1.25;
                    Console.WriteLine($"{grade:f2}");
                }
                else if (typeRoom == "apartment" && rating == "negative")
                {
                    double nights = (days - 1) * 25.00;
                    double discount = nights * 0.65;
                    double grade = discount * 0.90;
                    Console.WriteLine($"{grade:f2}");
                }
                else if (typeRoom == "room for one person" && rating == "positive")
                {
                    double nights = (days - 1) * 18.00;
                    double grade = nights * 1.25;
                    Console.WriteLine($"{grade:f2}");
                }
                else if (typeRoom == "room for one person" && rating == "negative")
                {
                    double nights = (days - 1) * 18.00;
                    double grade = nights * 0.90;
                    Console.WriteLine($"{grade:f2}");
                }
                else if (typeRoom == "president apartment" && rating == "positive")
                {
                    double nights = (days - 1) * 35.00;
                    double discount = nights * 0.85;
                    double grade = discount * 1.25;
                    Console.WriteLine($"{grade:f2}");
                }
                else if (typeRoom == "president apartment" && rating == "negative")
                {
                    double nights = (days - 1) * 35.00;
                    double discount = nights * 0.85;
                    double grade = discount * 0.90;
                    Console.WriteLine($"{grade:f2}");
                }
            }
            if (days < 10)
            {
                if (typeRoom == "room for one person" && rating == "positive")
                {
                    double nights = (days - 1) * 18.00;
                    double grade = nights * 1.25;
                    Console.WriteLine($"{grade:f2}");
                }
                else if (typeRoom == "room for one person" && rating == "negative")
                {
                    double nights = (days - 1) * 18.00;
                    double grade = nights * 0.90;
                    Console.WriteLine($"{grade:f2}");
                }
                else if (typeRoom == "apartment" && rating == "positive")
                {
                    double nights = (days - 1) * 25.00;
                    double discount = nights * 0.70;
                    double grade = discount * 1.25;
                    Console.WriteLine($"{grade:f2}");
                }
                else if (typeRoom == "apartment" && rating == "negative")
                {
                    double nights = (days - 1) * 25.00;
                    double discount = nights * 0.70;
                    double grade = discount * 0.90;
                    Console.WriteLine($"{grade:f2}");
                }
                else if (typeRoom == "president apartment" && rating == "positive")
                {
                    double nights = (days - 1) * 35.00;
                    double discount = nights * 0.90;
                    double grade = discount * 1.25;
                    Console.WriteLine($"{grade:f2}");
                }
                else if (typeRoom == "president apartment" && rating == "negative")
                {
                    double nights = (days - 1) * 35.00;
                    double discount = nights * 0.90;
                    double grade = discount * 0.90;
                    Console.WriteLine($"{grade:f2}");
                }
            }
            if (days > 15)
            {
                if (typeRoom == "room for one person" && rating == "positive")
                {
                    double nights = (days - 1) * 18.00;
                    double grade = nights * 1.25;
                    Console.WriteLine($"{grade:f2}");
                }
                else if (typeRoom == "room for one person" && rating == "negative")
                {
                    double nights = (days - 1) * 18.00;
                    double grade = nights * 0.90;
                    Console.WriteLine($"{grade:f2}");
                }
                else if (typeRoom == "apartment" && rating == "positive")
                {
                    double nights = (days - 1) * 25.00;
                    double discount = nights * 0.50;
                    double grade = discount * 1.25;
                    Console.WriteLine($"{grade:f2}");
                }
                else if (typeRoom == "apartment" && rating == "negative")
                {
                    double nights = (days - 1) * 25.00;
                    double discount = nights * 0.50;
                    double grade = discount * 0.90;
                    Console.WriteLine($"{grade:f2}");
                }
                else if (typeRoom == "president apartment" && rating == "positive")
                {
                    double nights = (days - 1) * 35.00;
                    double discount = nights * 0.80;
                    double grade = discount * 1.25;
                    Console.WriteLine($"{grade:f2}");
                }
                else if (typeRoom == "president apartment" && rating == "negative")
                {
                    double nights = (days - 1) * 35.00;
                    double discount = nights * 0.80;
                    double grade = discount * 0.90;
                    Console.WriteLine($"{grade:f2}");
                }
            }
        }
    }
}
