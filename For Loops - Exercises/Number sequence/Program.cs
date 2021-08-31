using System;

namespace Number_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var max = int.MinValue;
            var min = int.MaxValue;

            for (int i = 1; i <= n; i++)
            {
                var num1 = int.Parse(Console.ReadLine());
                if (num1 >= max)
                {
                    max = num1;
                }
                if (num1 <= min)
                {
                    min = num1;
                }
            }
            Console.WriteLine($"Max number: {max}");
            Console.WriteLine($"Min number: {min}");
        }

    }                                                                   
}
