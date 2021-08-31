using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            var facto = 1;
            do
            {
                facto *= num;
                num--;

            } while (num > 1);
            Console.WriteLine(facto);
        }
    }
}
