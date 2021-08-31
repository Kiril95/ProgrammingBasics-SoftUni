using System;

namespace Half_sum_element
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var calc = 0;
            int max = int.MinValue;
            for (int i = 1; i <= n; i++)
            {
                var num1 = int.Parse(Console.ReadLine());
                if (num1 > max)
                {
                    max = num1;
                }
                calc += num1;
            }
            
            calc -= max;
            if (calc == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {max}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(calc - max)}");
            }
           
        }
    }
}
