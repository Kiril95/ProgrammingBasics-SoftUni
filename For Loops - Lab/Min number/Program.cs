using System;

namespace Min_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n =");
            int n = int.Parse(Console.ReadLine());
            var min = int.MaxValue;

            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num < min)
                {
                    min = num;
                }
            }
            Console.WriteLine($"min = {min}");
        }
    }
}
