using System;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int cargo = int.Parse(Console.ReadLine());

            //var sumTons = 0;
            double bus = 0;
            double truck = 0;
            double train = 0;

            for (int i = 0; i < cargo; i++)
            {
                var tons = int.Parse(Console.ReadLine());

                if (tons <= 3)
                {
                    bus += tons;
                }
                if (tons > 3 && tons <= 11)
                {
                    truck += tons;
                }
                if (tons > 11)
                {
                    train += tons;
                }
            }
            double sumTons = bus + truck + train;
            double averagePrice = (bus * 200 + truck * 175 + train * 120) / sumTons;
            bus = (bus / sumTons) * 100;
            truck = (truck / sumTons) * 100;
            train = (train / sumTons) * 100;

            Console.WriteLine($"{averagePrice:f2}");
            Console.WriteLine($"{bus:f2}%");
            Console.WriteLine($"{truck:f2}%");
            Console.WriteLine($"{train:f2}%");
        }
    }
}
