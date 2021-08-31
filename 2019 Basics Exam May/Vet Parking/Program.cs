using System;

namespace Vet_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int counter = 0;
            double total = 0;
            double sum = 0;

            for (int i = 0; i < days; i++)
            {              
                //counter = 0;
                sum = 0;
                for (int j = 0; j < hours; j++)
                {
                    if (i % 2 == 1 && j % 2 == 0)
                    {
                        sum += 2.50;
                    }
                    else if (i % 2 == 0 && j % 2 == 1)
                    {
                        sum += 1.25;
                    }
                    else
                    {
                        sum += 1;
                    }                  
                }
                counter++;
                Console.WriteLine($"Day: {counter} - {sum:f2} leva");
                total += sum;
            }
            Console.WriteLine($"Total: {total:f2} leva");
        }
    }
}
