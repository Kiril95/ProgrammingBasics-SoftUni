using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var cinema = Console.ReadLine().ToLower();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            double income = -1;
            int full = rows * cols;

            switch (cinema)
            {
                case "Premiere": income = full * 12; break;
                case "Normal": income = full * 7.50; break;
                case "Discount": income = full * 5.00; break;

            }
            Console.WriteLine($"{income:f2} leva");
            
        }
    }
}
