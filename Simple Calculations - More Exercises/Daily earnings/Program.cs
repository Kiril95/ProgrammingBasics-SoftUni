using System;

namespace Daily_earnings
{
    class Program
    {
        static void Main(string[] args)
        {
            int workdaysMonth = int.Parse(Console.ReadLine());
            double moneyDay = double.Parse(Console.ReadLine());
            double dollarLev = double.Parse(Console.ReadLine());

            double monthSalary = workdaysMonth * moneyDay;
            double yearMoney = (monthSalary * 12) + (monthSalary * 2.5);
            double bonus = yearMoney * 0.25;
            double money = yearMoney - bonus;
            double moneyLev = money * dollarLev;
            double final = moneyLev / 365;
            Console.WriteLine(Math.Round(final, 2));
        }
    }
}
