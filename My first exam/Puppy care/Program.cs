using System;

namespace Puppy_care
{
    class Program
    {
        static void Main(string[] args)
        {
            int boughtFood = int.Parse(Console.ReadLine());
            int totalFood = boughtFood * 1000;
            string command = Console.ReadLine();
            double final = 0;
            double leftovers = 0;
            int eatenFood = 0;

            while (command != "Adopted")
            {
                //command = Convert.ToString(eatenFood);
                eatenFood = int.Parse(command);
                leftovers += eatenFood;
                command = Console.ReadLine();
            }
            
            if (leftovers <= totalFood)
            {
                final = totalFood - leftovers;
                Console.WriteLine($"Food is enough! Leftovers: {final} grams.");
            }
            else
            {
                final = totalFood - leftovers;
                Console.WriteLine($"Food is not enough. You need {Math.Abs(final)} grams more.");
            }

        }
    }
}
