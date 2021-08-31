using System;

namespace Pet_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int rest = int.Parse(Console.ReadLine());

            double final = (dogs * 2.50) + (rest * 4);

            Console.WriteLine($"{final} lv.");
        }
    }
}
