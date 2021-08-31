using System;

namespace Vegetable_market
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegcenaKg = double.Parse(Console.ReadLine());
            double frucenaKg = double.Parse(Console.ReadLine());
            int vegKg = int.Parse(Console.ReadLine());
            int fruKg = int.Parse(Console.ReadLine());

            double vegTotal = vegcenaKg * vegKg;
            double fruTotal = frucenaKg * fruKg;
            double sum = (vegTotal + fruTotal) / 1.94;

            Console.WriteLine($"{sum:f2}");
        }
    }
}
