using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var f0 = 1;
            var f1 = 1;

            for (int i = 0; i < num-1; i++)
            {
                var next = f0 + f1;
                f0 = f1;
                f1 = next;
            }
            Console.WriteLine(f1);
        }
    }
}
