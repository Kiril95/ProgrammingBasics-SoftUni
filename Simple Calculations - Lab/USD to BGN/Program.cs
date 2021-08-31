using System;

namespace USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("USD =");
            var usd = double.Parse(Console.ReadLine());
            var lev = (usd * 1.79549);
            lev = Math.Round(lev, 2);
            Console.WriteLine("BGN = " + lev);
        }
    }
}
