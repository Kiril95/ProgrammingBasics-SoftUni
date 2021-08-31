using System;

namespace Hotel_room
{
    class Program
    {       

        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double apartment = 0;
            double studio = 0;

            if (month == "May" || month == "October")
            {
                studio = 50.00 * nights;
                apartment = 65.00 * nights;
                if (nights > 7 && nights <= 14) studio *= 0.95;
                else if (nights > 14) studio *= 0.70;
            }
            else if (month == "June" || month == "September")
            {
                studio = 75.20 * nights;
                apartment = 68.70 * nights;
                if (nights > 14) studio *= 0.80;
            }
            else if (month == "July" || month == "August")
            {
                studio = 76.00 * nights;
                apartment = 77.00 * nights;
            }
            if (nights > 14) apartment *= 0.90;

            Console.WriteLine($"Apartment: {apartment:F2} lv.");
            Console.WriteLine($"Studio: {studio:F2} lv.");
        }

    }
}