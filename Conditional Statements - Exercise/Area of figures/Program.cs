using System;

namespace Area_figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double length = double.Parse(Console.ReadLine());
                length *= length;
                Console.WriteLine($"{length:f3}");
            }
            else if (figure == "rectangle")
            {
                double side1 = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());
                double area = side1 * side2;
                Console.WriteLine($"{area:f3}");
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double area = radius * radius * Math.PI;
                Console.WriteLine($"{area:f3}");
            }
            else if (figure == "triangle")
            {
                double length = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double area = length * height / 2;
                Console.WriteLine($"{area:f3}");
            }
        }
    }
}
