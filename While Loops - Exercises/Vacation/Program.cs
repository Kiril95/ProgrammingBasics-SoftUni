using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double ownedMoney = double.Parse(Console.ReadLine());

            string action = Console.ReadLine(); 
            double spendOrSave = double.Parse(Console.ReadLine());

            double days = 0;
            double spending = 0;

            while (neededMoney > ownedMoney)
            {
                days++;
                if (action == "save")
                {
                    ownedMoney += spendOrSave;
                    spending = 0;
                }
                
                if (action == "spend")
                {
                    ownedMoney -= spendOrSave;
                    if (ownedMoney < 0)
                    {
                        ownedMoney = 0;
                    }                   
                    spending++;
                    if (spending == 5)
                    {
                        break;
                    }
                }
                if (neededMoney <= ownedMoney)
                {
                    Console.WriteLine($"You saved the money for {days} days.");
                    return;
                }
                action = Console.ReadLine();
                spendOrSave = double.Parse(Console.ReadLine());              
            }

            Console.WriteLine("You can't save the money.");
            Console.WriteLine(days);
        }
    }
}
