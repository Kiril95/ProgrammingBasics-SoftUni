using System;

namespace Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            double clothesNum = double.Parse(Console.ReadLine());

            var total = 0.0;
            var left = 0.0;
            var final = 0.0;
            double decoration = budget * 0.10;
            double clothing = clothesNum * people;

            if (people > 150)
            {
                double discount = clothing * 0.10;
                left = clothing - discount;
                total = left + decoration;
                final = budget - total;

            }
            else
            {
                total = decoration + clothing;
                final = budget - total;
            }
            if (final < 0)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(final):f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {final:f2} leva left.");
            }
        }
    }
}
