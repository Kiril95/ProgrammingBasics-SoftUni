using System;

namespace Odd_even_position
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

            for (int i = 1; i <= n; i++)
            {
                double num1 = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    if (num1 > evenMax)
                    {
                        evenMax = num1;
                    }
                    if (num1 < evenMin)
                    {
                        evenMin = num1;
                    }
                    evenSum += num1;
                }
                else
                {
                    if (num1 > oddMax)
                    {
                        oddMax = num1;
                    }
                    if (num1 < oddMin)
                    {
                        oddMin = num1;
                    }
                    oddSum += num1;
                }
            }
            Console.WriteLine("OddSum={0}", oddSum);


            if (oddMin == double.MaxValue)
            {

                Console.WriteLine("OddMin=No");
            }
            else
            {
                Console.WriteLine("OddMin={0}", oddMin);
            }
            if (oddMax == double.MinValue)
            {

                Console.WriteLine("OddMax=No");
            }
            else
            {
                Console.WriteLine("OddMax={0}", oddMax);
            }
            
            Console.WriteLine("EvenSum={0}", evenSum);
            
            if (evenMin == double.MaxValue)
            {

                Console.WriteLine("EvenMin=No");
            }
            else
            {
                Console.WriteLine("EvenMin={0}", evenMin);
            }
            if (evenMax == double.MinValue)
            {

                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine("EvenMax={0}", evenMax);
            }
            
        }
    }
}
