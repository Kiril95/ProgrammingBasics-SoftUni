using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabs = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());
            //var website = 0.0;

            for (int i = 0; i < tabs; i++)
            {
                string web = Console.ReadLine();
                if (web == "Facebook")
                {
                    salary -= 150;
                }
                else if (web == "Instagram")
                {
                    salary -= 100;
                }
                else if (web == "Reddit")
                {
                    salary -= 50;
                }
            }
            if (salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary);
            }
          
        }
    }
}
