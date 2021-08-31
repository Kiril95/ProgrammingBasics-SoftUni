using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 0; i < n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (number < 200)
                {
                    p1++;
                }
                if (number >= 200 && number <= 399)
                {
                    p2++;
                }
                if (number >= 400 && number <= 599)
                {
                    p3++;
                }
                if (number >= 600 && number <= 799)
                {
                    p4++;
                }
                if (number >= 800)
                {
                    p5++;
                }                
            }
            p1 = (p1 / n) * 100;
            Console.WriteLine($"{p1:f2}%");
            p2 = (p2 / n) * 100;
            Console.WriteLine($"{p2:f2}%");
            p3 = (p3 / n) * 100;
            Console.WriteLine($"{p3:f2}%");
            p4 = (p4 / n) * 100;
            Console.WriteLine($"{p4:f2}%");
            p5 = (p5 / n) * 100;
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
