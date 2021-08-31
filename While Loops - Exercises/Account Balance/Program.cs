using System;

namespace Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            var balance = 0.0;
            
            while (command != "NoMoreMoney")
            {
                double money = double.Parse(command);
                if (money < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                
                Console.WriteLine($"Increase: {money:f2}");
                balance += money;
                command = Console.ReadLine();                                            
            }
            Console.WriteLine($"Total: {balance:f2}");
        }
    }
}
