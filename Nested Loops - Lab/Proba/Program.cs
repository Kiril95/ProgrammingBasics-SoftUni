using System;

namespace Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = " ";
            string category = " ";

            double allStudent = 0;
            double allStandard = 0;
            double allKids = 0;
            
            double final = 0;
            while (movie != "Finish")
            {
                if (category == "Finish")
                {
                    break;
                }
                double studentT = 0;
                double standardT = 0;
                double kidsT = 0;
                double ticketsCount = 0;
                movie = Console.ReadLine();
                double freeSeats = double.Parse(Console.ReadLine());
                category = Console.ReadLine();

                while (ticketsCount <= freeSeats)
                {
                    if (category == "Finish")
                    {
                        break;
                    }
                    else if (category == "End")
                    {
                        break;
                    }

                    ticketsCount++;

                    if (category == "student")
                    {
                        studentT++;
                    }
                    else if (category == "standard")
                    {
                        standardT++;
                    }
                    else if (category == "kid")
                    {
                        kidsT++;
                    }
                    category = Console.ReadLine();
                }
                allStudent += studentT;
                allStandard += standardT;
                allKids += kidsT;
                final = (studentT + standardT + kidsT) * 100 / freeSeats;
                Console.WriteLine($"{movie} - {final:f2}% full.");

            }
            double totalT = allStandard + allStudent + allKids;
            allStudent = allStudent * 100 / totalT;
            allStandard = allStandard * 100 / totalT;
            allKids = allKids * 100 / totalT;
            Console.WriteLine($"Total tickets: {totalT}");
            Console.WriteLine($"{allStudent:f2}% student tickets.");
            Console.WriteLine($"{allStandard:f2}% standard tickets.");
            Console.WriteLine($"{allKids:f2}% kids tickets.");
        }
    }
}