using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int diluent = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double one = (nylon + 2) * 1.50;
            double two = (paint * 1.10) * 14.50;
            double three = diluent * 5.00;
            double total = one + two + three + 0.40;
            double payday = (total * 0.30 * hours) + total;
            Console.WriteLine($"Total expenses: {payday:f2} lv.");

        }
    }
}
