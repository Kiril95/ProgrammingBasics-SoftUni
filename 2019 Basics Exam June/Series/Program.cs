using System;

namespace Series
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int series = int.Parse(Console.ReadLine());

            double sum = 0;
            double total = 0;

            for (int i = 0; i < series; i++)
            {
                string movie = Console.ReadLine();
                double priceTv = double.Parse(Console.ReadLine());

                if (movie == "Thrones")
                {
                    sum = priceTv * 0.50;
                }
                else if (movie == "Lucifer")
                {
                    sum = priceTv * 0.60;

                }
                else if (movie == "Protector")
                {
                    sum = priceTv * 0.70;

                }
                else if (movie == "TotalDrama")
                {
                    sum = priceTv * 0.80;

                }
                else if (movie == "Area")
                {
                    sum = priceTv * 0.90;

                }
                else
                {
                    sum = priceTv;
                }
                total += sum;

            }
            if (budget >= total)
            {
                Console.WriteLine($"You bought all the series and left with {budget - total:f2} lv.");
            }
            else
            {
                Console.WriteLine($"You need {Math.Abs(budget - total):f2} lv. more to buy the series!");
            }

        }
    }
}
