using System;

namespace Aluminum_Joinery
{
    class Program
    {
        static void Main(string[] args)
        {
            double numJoinery = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string delivery = Console.ReadLine();
            double sum = 0;

            if (numJoinery < 10)
            {
                Console.WriteLine("Invalid order");
                return;
            }           
            if (type == "90X130")
            {
                sum = numJoinery * 110;
                if (numJoinery > 30 && numJoinery <= 60)
                {
                    sum *= 0.95;
                }
                else if (numJoinery > 60)
                {
                    sum *= 0.92;
                }
            }
            else if (type == "100X150")
            {
                sum = numJoinery * 140;
                if (numJoinery >= 40 && numJoinery <= 80)
                {
                    sum *= 0.94;
                }
                else if (numJoinery > 80)
                {
                    sum *= 0.90;
                }
            }
            else if (type == "130X180")
            {
                sum = numJoinery * 190;
                if (numJoinery >= 20 && numJoinery <= 50)
                {
                    sum *= 0.93;
                }
                else if (numJoinery > 50)
                {
                    sum *= 0.88;
                }
            }
            else if (type == "200X300")
            {
                sum = numJoinery * 250;
                if (numJoinery >= 25 && numJoinery <= 50)
                {
                    sum *= 0.91;
                }
                else if (numJoinery > 50)
                {
                    sum *= 0.86;
                }
            }
            if (delivery == "With delivery")
            {
                sum += 60;
            }
            if (numJoinery > 99)
            {
                sum *= 0.96;
            }
            Console.WriteLine($"{sum:f2} BGN");
        }
    }
}
