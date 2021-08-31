using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine().ToLower(); // Високосна и нормална година
            double holidays = double.Parse(Console.ReadLine());
            double weekends = double.Parse(Console.ReadLine());
            double weekSofia = 48 - weekends;
            double playSofia = (weekSofia * 3 / 4) + (holidays * 2 / 3) + weekends;

            if (year == "normal")
            {
                Console.WriteLine($"{Math.Floor(playSofia)}:f2");
            }
            else
            {
                Console.WriteLine($"{Math.Floor(playSofia * 0.15 + playSofia)}:f2");
            }
        }
    }
}
