using System;

namespace Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            double inheritedMoney = double.Parse(Console.ReadLine());
            double yearsLiving = double.Parse(Console.ReadLine());
            var years = 18;

            for (int year = 1800; year <= yearsLiving; year++)
            {                
                if (year % 2 == 0)
                {
                    inheritedMoney -= 12000;
                }
                else
                {
                    inheritedMoney -= 12000 + 50 * years;
                }
                years++;
            }
            if (inheritedMoney >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have " +
                    $"{inheritedMoney:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(inheritedMoney):f2} dollars to survive.");
            }
        }
    }
}
