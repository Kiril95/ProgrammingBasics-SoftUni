using System;

namespace Convertor_for_currency
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var vhod = Console.ReadLine();
            var izhod = Console.ReadLine();
            var USD = 1.79549;
            var EUR = 1.95583;
            var GBP = 2.53405;

            if ((vhod == "BGN") && (izhod == "USD"))
            {
                Console.WriteLine(Math.Round(a / USD, 2));
            }
            else if ((vhod == "BGN") && (izhod == "EUR"))
            {
                Console.WriteLine(Math.Round(a / EUR, 2));
            }
            else if ((vhod == "BGN") && (izhod == "GBP"))
            {
                Console.WriteLine(Math.Round(a / GBP, 2));
            }
            if ((vhod == "USD") && (izhod == "BGN"))
            {
                Console.WriteLine(Math.Round(a * USD, 2));
            }
            else if ((vhod == "USD") && (izhod == "EUR"))
            {
                Console.WriteLine(Math.Round((a * USD) / EUR, 2));
            }
            else if ((vhod == "USD") && (izhod == "GBP"))
            {
                Console.WriteLine(Math.Round((a * USD) / GBP, 2));
            }
            if ((vhod == "EUR") && (izhod == "BGN"))
            {
                Console.WriteLine(Math.Round(a * EUR, 2));
            }
            else if ((vhod == "EUR") && (izhod == "USD"))
            {
                Console.WriteLine(Math.Round((a * EUR) / USD, 2));
            }
            else if ((vhod == "EUR") && (izhod == "GBP"))
            {
                Console.WriteLine(Math.Round((a * EUR) / GBP, 2));
            }
            if ((vhod == "GBP") && (izhod == "BGN"))
            {
                Console.WriteLine(Math.Round((a * GBP), 2));
            }
            else if ((vhod == "GBP") && (izhod == "USD"))
            {
                Console.WriteLine(Math.Round((a * GBP) / USD, 2));
            }
            else if ((vhod == "GBP") && (izhod == "EUR"))
            {
                Console.WriteLine(Math.Round((a * GBP) / EUR, 2));
            }

        }
    }
    
}
