using System;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            double onePage = double.Parse(Console.ReadLine());
            double cover = double.Parse(Console.ReadLine());
            double prcDiscount = double.Parse(Console.ReadLine());
            double sumDesigner = double.Parse(Console.ReadLine());
            double prcTotal = double.Parse(Console.ReadLine());

            double first = (onePage * 899) + (cover * 2);
            double second = (first * prcDiscount) / 100;
            double second2 = first - second;
            double third = second2 + sumDesigner;
            double fourth = (third * prcTotal) / 100;
            double final = third - fourth;
            Console.WriteLine($"Avtonom should pay {final:f2} BGN.");

        }
    }
}
