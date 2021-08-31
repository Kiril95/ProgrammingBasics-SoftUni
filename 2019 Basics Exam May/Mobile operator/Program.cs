using System;

namespace Mobile_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            string termContract = Console.ReadLine();
            string typeOfContract = Console.ReadLine();
            string internet = Console.ReadLine();
            double months = double.Parse(Console.ReadLine());
            double sum = 0;

            if (termContract == "one")
            {
                if (typeOfContract == "Small")
                {
                    sum = 9.98;
                }
                else if (typeOfContract == "Middle")
                {
                    sum = 18.99;
                }
                else if (typeOfContract == "Large")
                {
                    sum = 25.98;
                }
                else if (typeOfContract == "ExtraLarge")
                {
                    sum = 35.99;
                }              
            }
            else if (termContract == "two")
            {
                if (typeOfContract == "Small")
                {
                    sum = 8.58;
                }
                else if (typeOfContract == "Middle")
                {
                    sum = 17.09;
                }
                else if (typeOfContract == "Large")
                {
                    sum = 23.59;
                }
                else if (typeOfContract == "ExtraLarge")
                {
                    sum = 31.79;
                }
            }
            if (internet == "yes")
            {
                if (sum <= 10)
                {
                    sum += 5.50;
                }
                else if (sum <= 30)
                {
                    sum += 4.35;
                }
                else if (sum > 30)
                {
                    sum += 3.85;
                }
            }
            double final = sum * months;
            if (termContract == "two")
            {
                final *= 0.9625;
            }
            Console.WriteLine($"{final:f2} lv.");

        }
    }
}
