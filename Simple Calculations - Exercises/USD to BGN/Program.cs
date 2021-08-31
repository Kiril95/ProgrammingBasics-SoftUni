using System;

namespace Deposit_calc
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());
            int term = int.Parse(Console.ReadLine());
            double yearTax = double.Parse(Console.ReadLine());
            
            
            double total = sum + term * ((sum * yearTax / 100) / 12);

            Console.WriteLine(total);
        }
    }
}
