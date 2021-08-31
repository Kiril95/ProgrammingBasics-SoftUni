using System;

namespace Odd_even_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var oddSum = 0.0;
            var evenSum = 0.0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    oddSum += num;
                }
                else
                {
                    evenSum += num;          
                }             
            }
            if (oddSum == evenSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {oddSum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(evenSum - oddSum)}");
            }

        }    
    }
}
