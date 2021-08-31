using System;

namespace AND_Processors
{
    class Program
    {
        static void Main(string[] args)
        {
            double processorsNeeded = double.Parse(Console.ReadLine());
            double workers = double.Parse(Console.ReadLine());
            double workDays = double.Parse(Console.ReadLine());

            double total = 0;

            double hours = workers * workDays * 8;
            double created = Math.Floor(hours / 3);
            total = processorsNeeded - created;
            
            if (created < processorsNeeded)
            {
                double losses = total * 110.10;
                Console.WriteLine($"Losses: -> {Math.Abs(losses):f2} BGN");
            }
            else
            {
                double profit = total * 110.10;
                Console.WriteLine($"Profit: -> {Math.Abs(profit):f2} BGN");
            }

        }
    }
}
