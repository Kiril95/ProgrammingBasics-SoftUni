using System;

namespace Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int poorGrades = int.Parse(Console.ReadLine());
            string nameEquation = Console.ReadLine();
            int grade = int.Parse(Console.ReadLine());

            double averageScore = 0;
            int numEquations = 0;
            string lastEquation = " ";
            int numPoorGrades = 0;

            while (nameEquation != "Enough")
            {
                averageScore += grade;
                numEquations++;
                
                if (grade <= 4)
                {
                    numPoorGrades++;
                }
                if (poorGrades == numPoorGrades)
                {
                    Console.WriteLine($"You need a break, {numPoorGrades} poor grades.");
                    return;
                }
                lastEquation = nameEquation;
                nameEquation = Console.ReadLine();
                if ("Enough" == nameEquation)
                {
                    break;
                }
                grade = int.Parse(Console.ReadLine());
            }   
            
            averageScore /= numEquations;
            Console.WriteLine($"Average score: {averageScore:f2}");
            Console.WriteLine($"Number of problems: {numEquations}");
            Console.WriteLine($"Last problem: {lastEquation}");
        }
    }
}
