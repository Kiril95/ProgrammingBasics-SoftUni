using System;

namespace Fruit_market
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberriesLeva = double.Parse(Console.ReadLine());
            double bananasKg = double.Parse(Console.ReadLine());
            double orangesKg = double.Parse(Console.ReadLine());
            double raspberriesKg = double.Parse(Console.ReadLine());
            double strawberriesKg = double.Parse(Console.ReadLine());

            double raspKg = strawberriesLeva / 2;
            double oranKg = raspKg * 0.60;
            double bananKg = raspKg * 0.20;
            double raspLeva = raspKg * raspberriesKg;
            double orangeBananaLeva = (orangesKg * oranKg) + (bananasKg * bananKg);           
            double strawberries = strawberriesLeva * strawberriesKg;

            double total = raspLeva + orangeBananaLeva  + strawberries;

            Console.WriteLine($"{total:f2}");
        }
    }
}
