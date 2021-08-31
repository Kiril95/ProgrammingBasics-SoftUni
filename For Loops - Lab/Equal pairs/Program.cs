using System;

namespace Equal_pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double min = double.MaxValue;
            double max = double.MinValue;

            for (int i = 1; i <= n; i++)
            {
                double num1 = double.Parse(Console.ReadLine());
                double num2 = double.Parse(Console.ReadLine());
                double total = num1 + num2;
                if (total > max)
                {
                    max = total;
                }
                if (total < min)
                {
                    min = total;
                }              
            }
            if (max == min)
            {
                Console.WriteLine($"Yes, value = {max}");
            }
            else if (max != min)
            {
                Console.WriteLine($"No, maxdiff = {(max - min)}");
            }
        }
    }
}
