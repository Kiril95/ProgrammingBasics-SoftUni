using System;

namespace fhg
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var max = int.MinValue; var min = int.MaxValue;
            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                var num2 = int.Parse(Console.ReadLine());
                var sum = num2 + num;
                if (sum > max) max = sum;
                if (sum < min) min = sum;

            }
            if (max == min) Console.WriteLine($"Yes, value = {max}");
            else if (max != min) Console.WriteLine($"No, maxdiff = {max - min}");
        }
    }
}
