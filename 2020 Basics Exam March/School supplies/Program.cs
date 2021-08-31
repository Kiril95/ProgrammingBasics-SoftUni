using System;

namespace School_supplies
{
    class Program
    {
        static void Main(string[] args)
        {
            double pens = double.Parse(Console.ReadLine());
            double markers = double.Parse(Console.ReadLine());
            double cleaning = double.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());

            pens *= 5.80;
            markers *= 7.20;
            cleaning *= 1.20;
            double sum = pens + markers + cleaning;
            double discount = sum - (sum * percent / 100);

            Console.WriteLine($"{discount:f3}");
        }
    }
}
