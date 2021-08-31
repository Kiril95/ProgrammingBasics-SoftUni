using System;

namespace Series_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int seasones = int.Parse(Console.ReadLine());
            int episodes = int.Parse(Console.ReadLine());
            double commercials = double.Parse(Console.ReadLine());

            double commerc = (commercials * 0.20) + commercials;
            double special = seasones * 10;
            double total = commerc * episodes * seasones + special;

            Console.WriteLine($"Total time needed to watch the {name} series is {Math.Floor(total)} minutes.");

        }
    }
}
