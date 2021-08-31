using System;

namespace Oscars_week_in_cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            string category = Console.ReadLine();
            double tickets = double.Parse(Console.ReadLine());
            var total = 0.0;

            if (category == "normal")
            {
                if (movie == "A Star Is Born")
                {
                    total = tickets * 7.50;
                }
                else if (movie == "Bohemian Rhapsody")
                {
                    total = tickets * 7.35;
                }
                else if (movie == "Green Book")
                {
                    total = tickets * 8.15;
                }
                else if (movie == "The Favourite")
                {
                    total = tickets * 8.75;
                }
            }
            else if (category == "luxury")
            {
                if (movie == "A Star Is Born")
                {
                    total = tickets * 10.50;
                }
                else if (movie == "Bohemian Rhapsody")
                {
                    total = tickets * 9.45;
                }
                else if (movie == "Green Book")
                {
                    total = tickets * 10.25;
                }
                else if (movie == "The Favourite")
                {
                    total = tickets * 11.55;
                }
            }
            else if (category == "ultra luxury")
            {
                if (movie == "A Star Is Born")
                {
                    total = tickets * 13.50;
                }
                else if (movie == "Bohemian Rhapsody")
                {
                    total = tickets * 12.75;
                }
                else if (movie == "Green Book")
                {
                    total = tickets * 13.25;
                }
                else if (movie == "The Favourite")
                {
                    total = tickets * 13.95;
                }
            }
            Console.WriteLine($"{movie} -> {total:f2} lv.");
        }
    }
}
