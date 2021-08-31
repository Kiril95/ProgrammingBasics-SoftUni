using System;

namespace Movie_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            int numTickets = int.Parse(Console.ReadLine());
            double priceTickets = double.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            double one = (numTickets * priceTickets) * days;
            double prcIncome = one * percentage / 100;
            double income = one - prcIncome;

            Console.WriteLine($"The profit from the movie {name} is {income:f2} lv.");

        }
    }
}
