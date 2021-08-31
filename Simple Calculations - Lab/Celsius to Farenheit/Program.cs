using System;

namespace Celsius_to_Farenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Celsius = ");
            double Celsius = double.Parse(Console.ReadLine());
            double Fahrenheit = (Celsius * 9 / 5 + 32);
            Fahrenheit = Math.Round(Fahrenheit, 2);
            Console.WriteLine("Fahrenheit = " + Fahrenheit);

           
        }
    }
}
