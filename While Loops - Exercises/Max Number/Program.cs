using System;

namespace Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();           
            double max = int.MinValue;

            while (command != "Stop")
            {
                double number = double.Parse(command);
                if (number > max)
                {
                    max = number;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(max);
        }
    }
}
