using System;

namespace Tournament_of_Christmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            
            int daysWon = 0;
            int daysLost = 0;
            double total = 0;

            for (int i = 1; i <= days; i++)
            {
                int gamesWon = 0;
                int gamesLost = 0;
                double dailySum = 0;

                while (true)
                {
                    string command = Console.ReadLine();
                    if (command == "Finish")
                    {
                        break;
                    }
                    command = Console.ReadLine();
                    if (command == "win")
                    {
                        gamesWon++;
                        dailySum += 20;
                    }
                    else if (command == "lose")
                    {
                        gamesLost++;
                    }

                }
                if (gamesWon > gamesLost)
                {
                    daysWon++;
                    dailySum *= 1.10;
                }
                else
                {
                    daysLost++;
                }
                total += dailySum;
            }

            if (daysWon > daysLost)
            {
                total *= 1.20;
                Console.WriteLine($"You won the tournament! Total raised money: {total:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {total:f2}");
            }
        }
    }
}
