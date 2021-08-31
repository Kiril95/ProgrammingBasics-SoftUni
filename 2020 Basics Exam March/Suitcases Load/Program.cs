using System;

namespace Suitcases_Load
{
    class Program
    {
        static void Main(string[] args)
        {
            double capacity = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            double size = 0;
            int suitcase = 0;

            while (command != "End")
            {               
                size = double.Parse(command);
                suitcase++;
                if (suitcase % 3 == 0)
                {
                    size *= 1.10;
                }
                
                if (capacity < size)
                {
                    suitcase--;
                    Console.WriteLine("No more space!");
                    Console.WriteLine($"Statistic: {suitcase} suitcases loaded.");
                    return;
                }
                capacity -= size;
                command = Console.ReadLine();  
                
            }
            Console.WriteLine("Congratulations! All suitcases are loaded!");
            Console.WriteLine($"Statistic: {suitcase} suitcases loaded.");
        }
    }
}
