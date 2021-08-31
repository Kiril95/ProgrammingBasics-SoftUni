using System;

namespace Charity
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int cooks = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            double waffles = double.Parse(Console.ReadLine());
            double pancakes = double.Parse(Console.ReadLine());

            cakes *= 45;
            waffles *= 5.80;
            pancakes *= 3.20;
            double allDay = (cakes + waffles + pancakes) * cooks;
            double allCampaign = allDay * days;
            double expenses = allCampaign * 1/8;
            double final = allCampaign - expenses;

            Console.WriteLine(final);

        }
    }
}
