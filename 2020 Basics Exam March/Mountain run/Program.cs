using System;

namespace Mountain_run
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double secondsMeter = double.Parse(Console.ReadLine());

            double climb = distance * secondsMeter;
            double slow = Math.Floor(distance / 50) * 30;
            double total = climb + slow;
            
            if (record <= total) 
            {               
                total -= record;
                Console.WriteLine($"No! He was {total:f2} seconds slower.");
            }
         
            else if (record > total)
            {
                Console.WriteLine($"Yes! The new record is {total:f2} seconds.");               
            }
           
        }
    }
}
