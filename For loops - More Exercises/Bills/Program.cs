using System;

namespace Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            double month = double.Parse(Console.ReadLine());

            var electricity = 0.0;
            var water = 0.0;
            var internet = 0.0;
            var others = 0.0;
            var average = 0.0;
            var total = 0.0;

            for (int i = 0; i < month; i++)
            {
                double electro = double.Parse(Console.ReadLine());

                electricity += electro;
                water += 20;
                internet += 15;
                others = (electro + 20 + 15) * 1.20;
                total += others;
                average = (electricity + water + internet + total) / month;
            }
            Console.WriteLine($"Electricity: {electricity:f2} lv");
            Console.WriteLine($"Water: {water:f2} lv");
            Console.WriteLine($"Internet: {internet:f2} lv");
            Console.WriteLine($"Other: {total:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");
        }
    }
}
