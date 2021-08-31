using System;

namespace Odd__Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            double oddSum = 0.0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;

            double evenSum = 0.0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            for (int i = 0; i < n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    oddSum += num;
                    if (num > oddMax)
                    {
                        oddMax = num;
                    }
                    if (num < oddMin)
                    {
                        oddMin = num;
                    }
                }
                else
                {
                    evenSum += num;
                    if (num > evenMax)
                    {
                        evenMax = num;
                    }
                    if (num < evenMin)
                    {
                        evenMin = num;
                    }
                }
            }
            Console.WriteLine($"OddSum={oddSum:f2},");
            
            if (oddMin == double.MaxValue && oddMax == double.MinValue)
            {
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
            }
            else if (oddMax == double.MinValue)
            {
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},"); 
            }
            else
            {
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
            }
            
            Console.WriteLine($"EvenSum={evenSum:f2},");

            if (evenMin == double.MaxValue && evenMax == double.MinValue)
            {
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else if (evenMax == double.MinValue)
            {
                Console.WriteLine($"EvenMin={evenMin:f2},");
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }
            else
            {
                Console.WriteLine($"EvenMin={evenMin:f2},");
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }
        }
    }
}
