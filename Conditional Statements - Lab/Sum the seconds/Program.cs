using System;

namespace Sum_the_seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double third = double.Parse(Console.ReadLine());
            int minutes = 0;

            double seconds = first + second + third;

            if (seconds >= 60)
            {
                minutes = 1;
                seconds = seconds - 60;
            }
            if (seconds >= 60)
            {
                minutes = 1;
                seconds = seconds - 60;
            }
            if (seconds < 10)
            {
                Console.WriteLine(minutes + ":0" + seconds);
            }
            else
            {
                Console.WriteLine(minutes + ":" + seconds);
            }
        }
    }
}
