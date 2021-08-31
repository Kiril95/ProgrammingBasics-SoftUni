using System;

namespace Agency_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int adults = int.Parse(Console.ReadLine());
            int kids = int.Parse(Console.ReadLine());
            double netAdult = double.Parse(Console.ReadLine());
            double tax = double.Parse(Console.ReadLine());
           
            double sum = 0;
            double calc = 0;
            double total = 0;

            sum = netAdult * 0.30;
            calc = netAdult + tax;
            sum += tax;
            total = (sum * kids) + (calc * adults);
            total *= 0.20;

            Console.WriteLine($"The profit of your agency from {name} tickets is {total:f2} lv.");
          
        }
    }
}
