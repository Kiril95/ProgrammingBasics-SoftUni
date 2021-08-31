using System;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine()); // необходимите часове
            var days = int.Parse(Console.ReadLine()); // дните, с които фирмата разполага
            var workers = int.Parse(Console.ReadLine()); // броят на всички служители

            double workDays = days * 0.90;
            double overTime = workDays * 8;
	        double overHours = workers * days * 2;	
            double total = Math.Floor(overTime + overHours);
	        double diff = Math.Abs(total - hours);

            if (hours <= total)
            {
                Console.WriteLine($"Yes!{diff} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{Math.Ceiling(diff)} hours needed.");
            }
        }
    }
}
