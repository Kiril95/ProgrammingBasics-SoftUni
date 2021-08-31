using System;

namespace Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double min = int.MaxValue;

            while (command != "Stop")
            {
                double number = double.Parse(command);
                if (number < min)
                {
                    min = number;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(min);
        }
    }
}
