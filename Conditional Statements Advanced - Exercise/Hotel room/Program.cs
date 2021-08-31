using System;

namespace Hotel_room
{
    class Program
    {
        private static string month1;

        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double apartment = 0.0;
            double studio = 0.0;            

            if (month == "May" || month == "October")
            {
                studio = 50.00 * nights;
                apartment = 65.00 * nights;
                if (nights > 7 && nights <= 14) studio -= studio * 0.05;
                else if (nights > 14) studio -= studio * 0.30;               
            }
            else if (month == "June" || month == "September")
            {
                studio = 75.20 * nights;
                apartment = 68.70 * nights;
                if (nights > 14) studio -= studio * 0.20;
            }
            else if (month == "July" || month == "August")
            {
                studio = 76.00 * nights;
                apartment = 77.00 * nights;               
            }
            if (nights > 14) apartment = apartment - apartment * 0.10;
            
            Console.WriteLine("Apartment: {0:F2} lv.", apartment);
            Console.WriteLine("Studio: {0:F2} lv.", studio);
        }    

    }
}
