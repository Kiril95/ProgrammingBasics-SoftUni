using System;

namespace Stop_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var M = int.Parse(Console.ReadLine());
            var S = int.Parse(Console.ReadLine());

            for (var num = M; num >= N; num--)
            {
                if (num % 2 == 0 && num % 3 == 0)
                {
                    if (num != S)
                    {
                        Console.Write(num + " ");
                    }
                    else if (num == S)
                    {
                        break;
                    }
                }
            }
        }
    }       
}
