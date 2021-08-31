using System;

namespace Add_Bags
{
    class Program
    {
        static void Main(string[] args)
        {
            double luggageOver20 = double.Parse(Console.ReadLine());      
            double luggageKg = double.Parse(Console.ReadLine());          
            double days = double.Parse(Console.ReadLine());    
            double luggageNum = double.Parse(Console.ReadLine());         
            double taxForLuggage = 0;
            double totalPrice = 0;

            if (luggageKg <= 10)
            {
                taxForLuggage = 0.20 * luggageOver20;
            }
            else if (luggageKg <= 20)
            {
                taxForLuggage = 0.5 * luggageOver20;
            }
            else if (luggageKg > 20)
            {
                taxForLuggage = luggageOver20;
            }

            if (days >= 30)
            {
                totalPrice = taxForLuggage * 1.10;
            }
            else if (days >= 7)
            {
                totalPrice = taxForLuggage * 1.15;
            }
            else if (days < 7)
            {
                totalPrice = taxForLuggage * 1.40;
            }

            double sum = totalPrice * luggageNum;

            Console.WriteLine($"The total price of bags is: {sum:f2} lv.");
        }
    }
}