using System;

namespace Sum_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter numbers:");
            var sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine($"sum = {sum}");

        }
    }
}
