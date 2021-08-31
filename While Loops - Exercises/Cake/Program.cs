using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            double size = width * lenght;
            double sum = 0;
            double final = 0;

            while (command != "STOP")
            {
                double cake = double.Parse(command);
                sum += cake;
                if (sum > size)
                {
                    final = sum - size;
                    Console.WriteLine($"No more cake left! You need {final} pieces more.");
                    return;
                }
                command = Console.ReadLine();
            }
            final = size - sum;
            Console.WriteLine($"{final} pieces are left.");
        }
    }
}
