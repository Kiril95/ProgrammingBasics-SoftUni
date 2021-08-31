using System;

namespace Perimeter_and_area_of_a_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Circle radius. r = ");
            var r = double.Parse(Console.ReadLine());
            Console.WriteLine("Area = " + Math.PI * r * r);
            Console.WriteLine("Perimeter = " + 2 * Math.PI * r);


        }
    }
}
