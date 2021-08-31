using System;

namespace School_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            length *=  100;
            width *=  100;

            double column = Math.Truncate((width - 100) / 70);
            double rows = Math.Truncate(length / 120);
            double places = column * rows - 3;
            Console.WriteLine(places);
        }
    }
}
