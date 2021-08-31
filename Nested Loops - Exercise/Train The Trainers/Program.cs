using System;

namespace Train_The_Trainers
{
    class Program
    {
        static void Main()
        {
            TrainTheTrainers();
            //Trainers();
        }
        private static void Trainers()
        {
            int jury = int.Parse(Console.ReadLine());
            string name = " ";

            double allSum = 0;
            double allCount = 0;
            double average = 0;

            while (name != "Finish")
            {
                name = Console.ReadLine();
                if (name == "Finish")
                {
                    average = allSum / allCount;
                    Console.WriteLine($"Student's final assessment is {average:f2}.");
                    return;
                }
                double sum = 0;
                double counter = 0;

                while (true)
                {
                    double grade = double.Parse(Console.ReadLine());

                    sum += grade;
                    allSum += grade;
                    counter++;
                    allCount++;
                    if (counter == jury)
                    {
                        sum /= jury;
                        Console.WriteLine($"{name} - {sum:f2}.");
                        break;
                    }
                }
            }
        }

        
        private static void TrainTheTrainers()
        {
            int jury = int.Parse(Console.ReadLine());
            string name = " ";

            double allSum = 0;
            double allCount = 0;
            double average = 0;

            while (name != "Finish")
            {
                name = Console.ReadLine();
                if (name == "Finish")
                {
                    average = allSum / allCount;
                    Console.WriteLine($"Student's final assessment is {average:f2}.");
                    return;
                }
                double sum = 0;
                double counter = 0;

                for (int i = 0; i < jury; i++)
                {
                    double grade = double.Parse(Console.ReadLine());

                    sum += grade;
                    allSum += grade;
                    counter++;
                    allCount++;
                }

                if (counter == jury)
                {
                    sum /= jury;
                    Console.WriteLine($"{name} - {sum:f2}.");
                    continue;
                }
            }
        }
        
      
    }
}
