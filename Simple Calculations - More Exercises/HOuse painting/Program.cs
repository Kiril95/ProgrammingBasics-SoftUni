using System;

namespace HOuse_painting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine()); // височината на къщата 
            double y = double.Parse(Console.ReadLine()); // дължината на страничната стена 
            double h = double.Parse(Console.ReadLine()); // височината на триъгълната стена на прокрива 

            double window = 1.5 * 1.5;
            double allWalls = (x * x) * 2 - (1.2 * 2);
            double both = (x * y) * 2 - (2 * window);           
            double total = both + allWalls;
            double greenPaint = total / 3.4;
           
            double bothRoof = (x * y) * 2;
            double bothTriangles = x * h;
            double total2 = bothRoof + bothTriangles;
            double redPaint = total2 / 4.3;

            Console.WriteLine($"{greenPaint:f2}");
            Console.WriteLine($"{redPaint:f2}");
        }
    }
}
