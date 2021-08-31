using System;

namespace Metric_converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            var inNum = Console.ReadLine().ToLower();
            var outNum = Console.ReadLine().ToLower();

            if (inNum == "km")
            {
                num = num / 0.001;
            }
            if (inNum == "mm")
            {
                num = num / 1000;
            }
            if (inNum == "cm")
            {
                num = num / 100;
            }
            if (inNum == "mi")
            {
                num = num / 0.000621371192;
            }
            if (inNum == "in")
            {
                num = num / 39.3700787;
            }
            if (inNum == "ft")
            {
                num = num / 3.2808399;
            }
            if (inNum == "yd")
            {
                num = num / 1.0936133;
            }
            
            if (outNum == "km")
            {
                num = num * 0.001;
            }
            if (outNum == "mm")
            {
                num = num * 1000;
            }
            if (outNum == "cm")
            {
                num = num * 100;
            }
            if (outNum == "mi")
            {
                num = num * 0.000621371192;
            }
            if (outNum == "in")
            {
                num = num * 39.3700787;
            }
            if (outNum == "ft")
            {
                num = num * 3.2808399;
            }
            if (outNum == "yd")
            {
                num = num * 1.0936133;
            }
            Console.WriteLine(num + " " + outNum);


        }
        
    }
}
