using System;

namespace Working_Hours
{
    class Program
    {
        static void Main(string[] args)
        {
            double hour = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();
         
            if (hour >= 10 && hour <= 18)
            {
                if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday"
                    || day == "Friday" || day == "Saturday")
                {
                    Console.WriteLine("open");
                }
                if (day == "Sunday")
                {
                    Console.WriteLine("closed");
                }                           
            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}
