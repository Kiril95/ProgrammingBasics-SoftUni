using System;

namespace Convertor_for_currency
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var input = Console.ReadLine();
            var output = Console.ReadLine();
            var USD = 1.79549;
            var EUR = 1.95583;
            var GBP = 2.53405;

            if ((input == "BGN") && (izhod == "USD"))
            {
                Console.WriteLine(Math.Round(a / USD, 2));
            }
            else if ((input == "BGN") && (output == "EUR"))
            {
                Console.WriteLine(Math.Round(a / EUR, 2));
            }
            else if ((input == "BGN") && (output == "GBP"))
            {
                Console.WriteLine(Math.Round(a / GBP, 2));
            }
            if ((input == "USD") && (output == "BGN"))
            {
                Console.WriteLine(Math.Round(a * USD, 2));
            }
            else if ((input == "USD") && (output == "EUR"))
            {
                Console.WriteLine(Math.Round((a * USD) / EUR, 2));
            }
            else if ((input == "USD") && (output == "GBP"))
            {
                Console.WriteLine(Math.Round((a * USD) / GBP, 2));
            }
            if ((input == "EUR") && (output == "BGN"))
            {
                Console.WriteLine(Math.Round(a * EUR, 2));
            }
            else if ((input == "EUR") && (output == "USD"))
            {
                Console.WriteLine(Math.Round((a * EUR) / USD, 2));
            }
            else if ((input == "EUR") && (output == "GBP"))
            {
                Console.WriteLine(Math.Round((a * EUR) / GBP, 2));
            }
            if ((input == "GBP") && (output == "BGN"))
            {
                Console.WriteLine(Math.Round((a * GBP), 2));
            }
            else if ((input == "GBP") && (output == "USD"))
            {
                Console.WriteLine(Math.Round((a * GBP) / USD, 2));
            }
            else if ((input == "GBP") && (output == "EUR"))
            {
                Console.WriteLine(Math.Round((a * GBP) / EUR, 2));
            }

        }
    }
    
}
