using System;

namespace Game_Of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            double students = double.Parse(Console.ReadLine());

            double result = 0;
            double points = 0;
            double prOne = 0;
            double prTwo = 0;
            double prThree = 0;
            double prFour = 0;
            double prFive = 0;
            double prInvalid = 0;
            
            for (int i = 0; i < students; i++)
            {
                double currentNumber = double.Parse(Console.ReadLine());

                if (currentNumber >= 0 && currentNumber <= 9)
                {
                    prOne++;
                    points = (currentNumber * 20) / 100;
                    result += points;
                }
                if (currentNumber >= 10 && currentNumber <= 19)
                {
                    prTwo++;
                    points = (currentNumber * 30) / 100;
                    result += points;
                }
                if (currentNumber >= 20 && currentNumber <= 29)
                {
                    prThree++;
                    points = (currentNumber * 40) / 100;
                    result += points;
                }
                if (currentNumber >= 30 && currentNumber <= 39)
                {
                    prFour++;
                    result += 50;
                }
                if (currentNumber >= 40 && currentNumber <= 50)
                {
                    prFive++;
                    result += 100;
                }
                if (currentNumber < 0 || currentNumber > 50)
                {
                    prInvalid++;
                    result = result / 2;
                }
                
            }
            prOne = (prOne / students) * 100;
            prTwo = (prTwo / students) * 100;
            prThree = (prThree / students) * 100;
            prFour = (prFour / students) * 100;
            prFive = (prFive / students) * 100;
            prInvalid = (prInvalid / students) * 100;

            Console.WriteLine($"{result:f2}");
            Console.WriteLine($"From 0 to 9: {prOne:f2}%");
            Console.WriteLine($"From 10 to 19: {prTwo:f2}%");
            Console.WriteLine($"From 20 to 29: {prThree:f2}%");
            Console.WriteLine($"From 30 to 39: {prFour:f2}%");
            Console.WriteLine($"From 40 to 50: {prFive:f2}%");
            Console.WriteLine($"Invalid numbers: {prInvalid:f2}%");
        }
    }
}
