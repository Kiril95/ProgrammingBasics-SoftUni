using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());
            int count = 0;

            while (change > 0)
            {
                change = Math.Round(change, 2);
                if (change >= 2)
                {
                    count++;
                    change -= 2;
                }
                if (change >= 1)
                {
                    count++;
                    change -= 1;
                }
                if (change >= 0.50)
                {
                    count++;
                    change -= 0.50;
                }
                if (change >= 0.20)
                {
                    count++;
                    change -= 0.20;
                }
                if (change >= 0.10)
                {
                    count++;
                    change -= 0.10;
                }
                if (change >= 0.05)
                {
                    count++;
                    change -= 0.05;
                }
                if (change >= 0.02)
                {
                    count++;
                    change -= 0.02;
                }
                if (change >= 0.01)
                {
                    count++;
                    change -= 0.01;
                }                                                      
            }
            Console.WriteLine(count);
        }
    }
}
