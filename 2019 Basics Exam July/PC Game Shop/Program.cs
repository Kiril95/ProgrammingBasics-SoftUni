using System;

namespace PC_Game_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int soldGames = int.Parse(Console.ReadLine());
            double hearthstone = 0;
            double fornite = 0;
            double overwatch = 0;
            double others = 0;

            for (int i = 0; i < soldGames; i++)
            {
                string game = Console.ReadLine();
                if (game == "Hearthstone")
                {
                    hearthstone++;
                }
                else if (game == "Fornite")
                {
                    fornite++;
                }
                else if (game == "Overwatch")
                {
                    overwatch++;
                }
                else
                {
                    others++;
                }
            }
            hearthstone = hearthstone * 100 / soldGames;
            fornite = fornite * 100 / soldGames;
            overwatch = overwatch * 100 / soldGames;
            others = others * 100 / soldGames;
            Console.WriteLine($"Hearthstone - {hearthstone:f2}%");
            Console.WriteLine($"Fornite - {fornite:f2}%");
            Console.WriteLine($"Overwatch - {overwatch:f2}%");
            Console.WriteLine($"Others - {others:f2}%");

        }
    }
}
