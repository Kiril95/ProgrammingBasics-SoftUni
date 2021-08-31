using System;

namespace Radians_to_degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Radians = ");
            double rad = double.Parse(Console.ReadLine());
            double deg = Math.Round(rad * 180 / Math.PI);
            Console.WriteLine("Degrees = " + deg);

        }
    }
}
