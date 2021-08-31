using System;

namespace Movie_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            double budgetActors = double.Parse(Console.ReadLine());
            string nameOfActor = Console.ReadLine();
            double salaryOut = 0;

            while (nameOfActor != "ACTION")
            {
                if (nameOfActor.Length <= 15 && nameOfActor.Length > 0)
                {
                    double salary = double.Parse(Console.ReadLine());
                    salaryOut = salary;
                }
                else
                {
                    salaryOut = budgetActors * 0.20;
                }

                if (budgetActors < salaryOut)
                {
                    break;
                }
                budgetActors -= salaryOut;
                nameOfActor = Console.ReadLine();
            }
            if (budgetActors >= salaryOut)
            {
                Console.WriteLine($"We are left with {budgetActors:f2} leva.");
            }
            else
            {
                Console.WriteLine($"We need {(salaryOut - budgetActors):f2} leva for our actors.");
            }
        }
    }
}
