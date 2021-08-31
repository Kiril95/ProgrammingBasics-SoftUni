using System;

namespace Max_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            var max = int.MinValue;
            
            for (int i = 1; i <= n ; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine($"max = {max}");

        }
    }
}
