using System;

namespace On_time__exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examH = int.Parse(Console.ReadLine());
            int examM = int.Parse(Console.ReadLine());
            int arrivalH = int.Parse(Console.ReadLine());
            int arrivalM = int.Parse(Console.ReadLine());

            int exam = examH * 60 + examM;
            int arrival = arrivalH * 60 + arrivalM;
            int total = arrival - exam;
            int hours = Math.Abs(total / 60);
            int minutes = Math.Abs(total % 60);

            if (total < -30)
            {
                Console.WriteLine("Early");
            }
            else if (total < 0)
            {
                Console.WriteLine("On time");
            }
            else if (total == 0)
            {
                Console.WriteLine("On time");
            }
            else
            {
                Console.WriteLine("Late");
            }

            if (hours > 0)
            {
                if (minutes < 10)
                {
                    Console.Write(hours + ":0" + minutes + " hours");
                }
                else
                {
                    Console.Write(hours + ":" + minutes + " hours");
                }
            }
            else
            {
                Console.Write(minutes + " minutes");
            }

            if (total < 0)
            {
                Console.WriteLine(" before the start");
            }
            else
            {
                Console.WriteLine(" after the start");
            }
        }
    }
}
