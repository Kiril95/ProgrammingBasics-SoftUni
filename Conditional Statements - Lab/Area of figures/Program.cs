using System;

namespace Area_of_figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
                      
            if (a == "square")
            {
                var num = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(num * num, 3));
            }
            if (a == "rectangle")
            {
                var num = double.Parse(Console.ReadLine());
                var num2 = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(num * num2, 3));
            }
            if (a == "circle")
            {
                var num = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(Math.PI * num * num, 3));
            }
            if (a == "triangle")
            {
                var num = double.Parse(Console.ReadLine());
                var num2 = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(num * num2 / 2, 3));
            }

        }
    }
}
