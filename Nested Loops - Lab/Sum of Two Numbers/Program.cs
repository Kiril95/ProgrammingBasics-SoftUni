using System;

namespace Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int magicalN = int.Parse(Console.ReadLine());
            int counter = 0;
            int sum = 0;

            for (int x = num1; x <= num2; x++)
            {
                for (int y = num1; y <= num2; y++)
                {
                    sum = x + y;
                    counter++;
                    if (sum == magicalN)
                    {
                        Console.WriteLine($"Combination N:{counter} ({x} + {y} = {magicalN})");
                        return;
                    }                                  
                }               
            }
            Console.WriteLine($"{counter} combinations - neither equals {magicalN}");
        }
    }
}
