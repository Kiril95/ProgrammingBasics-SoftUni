using System;

namespace Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = " ";
            string category = " ";

            double allStud = 0;
            double allStand = 0;
            double allKids = 0;
            double totalTickets = 0;
            //int allTickets = 0;
            while (movie != "Finish")
            {
                movie = Console.ReadLine();
                if (movie == "Finish")
                {
                    break;
                }
                double studentT = 0;
                double standardT = 0;
                double kidsT = 0;

                double freeSeats = double.Parse(Console.ReadLine());

                for (double i = 0; i < freeSeats; i++)
                {
                    category = Console.ReadLine();
 
                    if (category == "End")
                    {
                        break;
                    }
                    //allTickets++;
                    else if (category == "student")
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
                }
                allStud += studentT;
                allStand += standardT;
                allKids += kidsT;
                Console.WriteLine($"{movie} - {((studentT + standardT + kidsT) * 100 / freeSeats):f2}% full.");

            }
            totalTickets = allStud + allStand + allKids;
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{(allStud * 100 / totalTickets):f2}% student tickets.");
            Console.WriteLine($"{(allStand * 100 / totalTickets):f2}% standard tickets.");
            Console.WriteLine($"{(allKids * 100 / totalTickets):f2}% kids tickets.");
        }
    }
}
