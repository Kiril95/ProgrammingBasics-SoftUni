using System;

namespace Name_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int charLetter = 0;
            int maxScore = 0;
            string winnerName = " ";

            while (name != "Stop")
            {
                int current = 0;

                for (int i = 0; i < name.Length; i++)
                {
                    charLetter = (int)name[i];

                    int n = int.Parse(Console.ReadLine());

                    if (charLetter == n)
                    {
                        current += 10;
                    }
                    else
                    {
                        current += 2;
                    }

                    if (current >= maxScore) 
                    {
                        maxScore = current;
                        winnerName = name;
                    }
                }
                name = (Console.ReadLine());
            }

            Console.WriteLine($"The winner is {winnerName} with {maxScore} points!");
        }
    }
}
