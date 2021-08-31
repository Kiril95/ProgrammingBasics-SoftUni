using System;

namespace Fish_market
{
    class Program
    {
        static void Main(string[] args)
        {
            double mackerelKg = double.Parse(Console.ReadLine());
            double spratKg = double.Parse(Console.ReadLine());
            double bonitoKg = double.Parse(Console.ReadLine());
            double scadKg = double.Parse(Console.ReadLine());
            int clamKg = int.Parse(Console.ReadLine());

            double bonitoPrice = mackerelKg * 0.60 + mackerelKg;
            double bonitoSum = bonitoKg * bonitoPrice;
            double scadPrice = spratKg * 0.80 + spratKg;
            double scadSum = scadKg * scadPrice;
            double clamSum = clamKg * 7.50;
            double check = bonitoSum + scadSum + clamSum;

            Console.WriteLine($"{check:f2}");

        }
    }
}
