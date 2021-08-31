using System;

namespace World_swimming_record
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordSec = double.Parse(Console.ReadLine());
            double distanceMet = double.Parse(Console.ReadLine());
            double secondsMeter = double.Parse(Console.ReadLine());

            double totalMet = distanceMet * secondsMeter;
            double newTime = Math.Floor(distanceMet / 15) * 12.5;
            double realTime = totalMet + newTime;

            if (recordSec <= realTime)
            {
                double final = realTime - recordSec;
                Console.WriteLine($"No, he failed! He was {final:f2} seconds slower.");
            }

            else if (recordSec > realTime)
            {               
                Console.WriteLine($"Yes, he succeeded! The new world record is {realTime:f2} seconds.");
            }
        }
    }
}
