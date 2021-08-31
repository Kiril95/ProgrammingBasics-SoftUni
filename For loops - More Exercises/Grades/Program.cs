using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());

            double top = 0;
            double fourFive = 0;
            double threeFour = 0;
            double three = 0;
            double average = 0;

            for (int i = 0; i < students; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                average += grade;
                if (grade >= 5.00)
                {
                    top++;
                }
                if (grade >= 4.00 && grade <= 4.99)
                {
                    fourFive++;
                }
                if (grade >= 3.00 && grade <= 3.99)
                {
                    threeFour++;
                }
                if (grade < 3.00)
                {
                    three++;
                }
            }
            top = (top / students) * 100;
            fourFive = (fourFive / students) * 100;
            threeFour = (threeFour / students) * 100;
            three = (three / students) * 100;
            average = (average / students);

            Console.WriteLine($"Top students: {top:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {fourFive:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {threeFour:f2}%");
            Console.WriteLine($"Fail: {three:f2}%");
            Console.WriteLine($"Average: {average:f2}");
        }
    }
}
