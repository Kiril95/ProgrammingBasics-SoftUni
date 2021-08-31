using System;

namespace Gold_Mine
{
    class Program
    {
        static void Main(string[] args)
        {
            int location = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < location; i++)
            {
                double average = 0;
                double total = 0;

                double expectedGold = double.Parse(Console.ReadLine());
                int daysMining = int.Parse(Console.ReadLine());
                
                for (int j = 0; j < daysMining; j++)
                {
                    double currentGold = double.Parse(Console.ReadLine());
                    total += currentGold;
                }
                average = total / daysMining;
                
                if (average >= expectedGold)
                {
                    Console.WriteLine($"Good job! Average gold per day: {average:f2}.");
                }
                else
                {
                    Console.WriteLine($"You need {expectedGold - average:f2} gold.");
                }
            }
        }
    }
}
