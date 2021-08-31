using System;

namespace Football_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            double games = double.Parse(Console.ReadLine());
            int wins = 0;
            int draws = 0;
            int losses = 0;
            int total = 0;
            double winRate = 0;
            if (games < 1)
            {
                Console.WriteLine($"{team} hasn't played any games during this season.");
                return;
            }
            for (int i = 0; i < games; i++)
            {
                string score = Console.ReadLine();
                if (score == "W")
                {
                    wins++;
                }
                else if (score == "D")
                {
                    draws++;
                }
                else if (score == "L")
                {
                    losses++;
                }
            }
            total = (wins * 3) + (draws * 1);
            winRate = (wins * 100) / games;
            Console.WriteLine($"{team} has won {total} points during this season.");
            Console.WriteLine("Total stats:");
            Console.WriteLine($"## W: {wins}");
            Console.WriteLine($"## D: {draws}");
            Console.WriteLine($"## L: {losses}");
            Console.WriteLine($"Win rate: {winRate:f2}%");

        }
    }
}
