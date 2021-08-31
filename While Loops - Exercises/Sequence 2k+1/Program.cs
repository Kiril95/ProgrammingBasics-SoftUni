using System;

namespace Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            var n = 1;

            while (n <= number)
            {
                Console.WriteLine(n);
                n = n * 2 + 1;
            }
        }
    }
}
