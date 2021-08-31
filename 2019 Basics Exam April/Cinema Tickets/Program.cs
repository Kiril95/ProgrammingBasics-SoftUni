using System;

namespace Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = " ";
            var student = 0.0;
            var standard = 0.0;
            var kid = 0.0;

            while (movie != "Finish")
            {
                movie = Console.ReadLine();
                if (movie == "Finish")
                {
                    break;
                }
                var allTickets = 0.0;
                int freeSeats = int.Parse(Console.ReadLine());

                for (int i = 0; i < freeSeats; i++)
                {
                    string type = Console.ReadLine();
                    if (type == "End")
                    {
                        break;
                    }
                    allTickets++;

                    if (type == "student")
                    {
                        student++;
                    }
                    else if (type == "standard")
                    {
                        standard++;
                    }
                    else if (type == "kid")
                    {
                        kid++;
                    }
                }
                Console.WriteLine($"{movie} - {(allTickets * 100) / freeSeats:f2}% full.");
            }
            double totalTickets = student + standard + kid;
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{(student * 100) / totalTickets:f2}% student tickets.");
            Console.WriteLine($"{(standard * 100) / totalTickets:f2}% standard tickets.");
            Console.WriteLine($"{(kid * 100) / totalTickets:f2}% kids tickets.");

        }
    }
}
