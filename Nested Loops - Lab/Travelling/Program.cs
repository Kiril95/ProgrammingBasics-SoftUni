using System;

class Program
{
    static void Main()
    {
        string destination = " ";

        while (destination != "End")
        {
            destination = Console.ReadLine();
            if (destination == "End")
            {
                return;
            }
            double budget = double.Parse(Console.ReadLine());
            double money = 0;
            double savings = 0;
            
            while (true)
            {
                money = double.Parse(Console.ReadLine());
                savings += money;

                if (savings >= budget)
                {
                    Console.WriteLine($"Going to {destination}!");
                    break;
                }
            }

        }
    }
}
