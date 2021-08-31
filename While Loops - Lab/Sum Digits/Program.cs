using System;

namespace Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var sum = 0;

            do
            {
                sum += num % 10;
                num /= 10;

            } while (num > 0);
            Console.WriteLine(sum);
        }
    }
}
