using System;

namespace Metric_converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            String metricIn = Console.ReadLine();
            String metricOut = Console.ReadLine();
            double finalNum = 0;

            if (metricIn == ("mm") && metricOut == ("cm"))
            {
                finalNum = num / 10;
            }
            else if (metricIn == ("mm") && metricOut == ("m"))
            {
                finalNum = num / 1000;
            }
            else if (metricIn == ("cm") && metricOut == ("mm"))
            {
                finalNum = num * 10;
            }
            else if (metricIn == ("cm") && metricOut == ("m"))
            {
                finalNum = num / 100;
            }
            else if (metricIn == ("m") && metricOut == ("mm"))
            {
                finalNum = num * 1000;
            }
            else if (metricIn == ("m") && metricOut == ("cm"))
            {
                finalNum = num * 100;
            }
            Console.WriteLine($"{finalNum:f3}");
        }            
    }
}
