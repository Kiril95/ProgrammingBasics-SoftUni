using System;

namespace Club
{
    class Program
    {
        static void Main(string[] args)
        {
            double desiredSum = double.Parse(Console.ReadLine());
            string coctail = Console.ReadLine();
            double total = 0;
            double end = 0;
            
            while (coctail != "Party!")
            {
                int numCoctails = int.Parse(Console.ReadLine());
                double price = coctail.Length;
                total = price * numCoctails;
                
                if (total % 2 != 0)
                {
                    total *= 0.75;
                }
                end += total;
                if (end >= desiredSum)
                {
                    Console.WriteLine("Target acquired.");
                    break;
                }
                coctail = Console.ReadLine();
            }
            if (coctail == "Party!")
            {
                Console.WriteLine($"We need {desiredSum - end:f2} leva more.");

            }
            Console.WriteLine($"Club income - {end:F2} leva.");
        }
    }
}
