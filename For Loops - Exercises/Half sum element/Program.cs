using System;

namespace Half_sum_element
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            int max = int.MinValue;
            for (int i = 0; i < n; i++)
            {              
                var num1 = int.Parse(Console.ReadLine());
                sum += num1;
                if (num1 > max)
                {
                    max = num1;
                }             
            }

            sum -= max;
            if (sum == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {max}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sum - max)}");
            }
        }
    }
}
