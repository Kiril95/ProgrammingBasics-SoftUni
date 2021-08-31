using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int steps = 0;
            var sum = 0;
            var diff = 0;

            while (command != "Going home")
            {
                steps = int.Parse(command);
                sum += steps;
                                                                          
                if (sum >= 10000)
                {
                    diff = sum - 10000;
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{diff} steps over the goal!");
                    return; 
                }               
                command = Console.ReadLine();

            }
            command = Console.ReadLine();
            steps = int.Parse(command);
            sum += steps;
            if (sum >= 10000)
            {
                diff = sum - 10000;
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{diff} steps over the goal!");
                
            }
            else if (sum < 10000)
            {
                diff = 10000 - sum;
                Console.WriteLine($"{diff} more steps to reach goal.");
                
            }
        }
    }
}
