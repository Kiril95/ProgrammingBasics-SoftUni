using System;

namespace Left_right_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var leftSum = 0.0;
            var rightSum = 0.0;

            for (int i = 0; i < n; i++)
            {
                int num1 = int.Parse(Console.ReadLine());
                leftSum += num1;                
            }
            for (int i = 0; i < n; i++)
            {
                int num2 = int.Parse(Console.ReadLine());
                rightSum += num2;
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                var difference = Math.Abs(rightSum - leftSum);
                Console.WriteLine($"No, diff = {difference}");
            }

        }
    }
}
