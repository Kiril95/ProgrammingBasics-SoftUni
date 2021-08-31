using System;

namespace Movie_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            double shooting = double.Parse(Console.ReadLine());
            double numScenes = double.Parse(Console.ReadLine());
            double timeScenes = double.Parse(Console.ReadLine());

            double terrain = shooting * 0.15;
            double fin = (numScenes * timeScenes) + terrain;

            if (fin >= shooting)
            {
                Console.WriteLine($"Time is up! To complete the movie you need " +
                    $"{Math.Round(fin - shooting)} minutes.");
            }
            else
            {             
                Console.WriteLine($"You managed to finish the movie on time! You have " +
                    $"{Math.Round(shooting - fin)} minutes left!");
            }

        }
    }
}
