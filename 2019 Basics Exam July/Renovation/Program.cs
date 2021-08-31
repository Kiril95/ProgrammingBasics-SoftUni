using System;

namespace Renovation
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int percentage = int.Parse(Console.ReadLine());
            double quadrants = (height * width * 4);
            double prc = (quadrants * percentage) / 100;
            double final = quadrants - prc;

            string command = Console.ReadLine();
            while (command != "Tired!")
            {               
                int litersPaint = int.Parse(command);
                final -= litersPaint;
                if (final < 0)
                {
                    Console.WriteLine($"All walls are painted and you have {Math.Abs(final)} l paint left!");
                    return;
                }
                else if (final == 0)
                {
                    Console.WriteLine($"All walls are painted! Great job, Pesho!");
                    return;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"{final} quadratic m left.");
        }
    }
}
