using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double incomeLev = double.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());
            double minimumWage = double.Parse(Console.ReadLine());

            double scholarship = Math.Floor(averageGrade * 25);
            double socialScholarship = Math.Floor(minimumWage * 0.35);

            if (averageGrade >= 5.50)
            {

                if (scholarship >= socialScholarship || incomeLev > minimumWage)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {scholarship} BGN");
                }
                else
                {
                    Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
                }
            }
            else if (incomeLev < minimumWage && averageGrade > 4.50)
            {
                Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }

        }
    }
}
