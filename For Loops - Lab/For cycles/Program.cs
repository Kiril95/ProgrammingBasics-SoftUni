using System;

namespace For_cycles
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 100; i++)
            {
                if (i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
