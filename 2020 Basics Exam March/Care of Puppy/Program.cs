using System;

namespace Care_of_Puppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int boughtFood = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int grams = 0;
            int sum = 0;
            int final = 0;
            int totalFood = boughtFood * 1000;

            while (command != "Adopted")
            {
                grams = int.Parse(command);
                sum += grams;
                command = Console.ReadLine(); 

            }
            if (totalFood >= sum)
            {
                final = totalFood - sum;
                Console.WriteLine($"Food is enough! Leftovers: {final} grams.");
            }
            else
            {
                final = sum - totalFood;
                Console.WriteLine($"Food is not enough. You need {final} grams more.");
            }
        }
    }
}
