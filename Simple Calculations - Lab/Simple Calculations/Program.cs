using System;

namespace Simple_Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a =");
            var a = int.Parse(Console.ReadLine());
            var area = a * a;
            Console.Write("Square area =");
            Console.WriteLine(area);
            
        }
    }
}
