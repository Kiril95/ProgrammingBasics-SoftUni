using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            double cubicM = width * length * height;
            double cubic = 0;
            double final = 0;
            while (command != "Done")
            {               
                double boxes = double.Parse(command);
                cubic += boxes;
                if (cubicM < cubic)
                {
                    final = cubicM - cubic;
                    Console.WriteLine($"No more free space! You need {Math.Abs(final)} Cubic meters more.");
                    break;
                }
                command = Console.ReadLine();           
            }          
            if (cubicM > cubic)
            {
                final = cubicM - cubic;
                Console.WriteLine($"{final} Cubic meters left.");
            }
        }
    }
}
