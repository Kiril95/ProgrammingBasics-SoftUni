using System;

namespace Film_Premiere
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            string package = Console.ReadLine();
            double tickets = double.Parse(Console.ReadLine());

            double sum = 0;

            if (movie == "John Wick")
            {
                if (package == "Drink")
                {
                    sum = 12;
                }
                else if (package == "Popcorn")
                {
                    sum = 15;
                }
                else if (package == "Menu")
                {
                    sum = 19;
                }
                sum *= tickets;
            }
            else if (movie == "Star Wars")
            {
                if (package == "Drink")
                {
                    sum = 18;
                }
                else if (package == "Popcorn")
                {
                    sum = 25;
                }
                else if (package == "Menu")
                {
                    sum = 30;
                }
                sum *= tickets;


                if (tickets >= 4)
                {
                    sum *= 0.70;
                }
            }
            else if (movie == "Jumanji")
            {
                if (package == "Drink")
                {
                    sum = 9;
                }
                else if (package == "Popcorn")
                {
                    sum = 11;
                }
                else if (package == "Menu")
                {
                    sum = 14;
                }
                sum *= tickets;

                if (tickets == 2)
                {
                    sum *= 0.85;
                }
            }
            Console.WriteLine($"Your bill is {sum:f2} leva.");

        }
    }
}
