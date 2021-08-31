using System;

namespace Graduation_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            //double grade = double.Parse(Console.ReadLine());
            double result = 0;
            double clas = 0;

            while (clas < 12)
            {
                double grade = double.Parse(Console.ReadLine());
                clas++;
                result += grade;
                if (clas == 12)
                {
                    result /= clas;
                    Console.WriteLine($"{name} graduated. Average grade: {result:f2}");
                }
                //grade = double.Parse(Console.ReadLine());
                            
                if (grade < 4.00)
                {                   
                    Console.WriteLine($"{name} has been excluded at {clas} grade");
                    break;
                }
            }

        }
    }
}
