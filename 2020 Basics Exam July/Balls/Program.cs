using System;

namespace Balls
{
    class Program
    {
        static void Main(string[] args)
        {
            int balls = int.Parse(Console.ReadLine());           
            int red = 0;
            int orange = 0;
            int yellow = 0;
            int white = 0;
            int black = 0;
            int others = 0;
            int total = 0;

            for (int i = 0; i < balls; i++)
            {
                string color = Console.ReadLine();
                if (color == "red")
                {
                    red++;
                    total += 5;
                }
                else if (color == "orange")
                {
                    orange++;
                    total += 10;
                }
                else if (color == "yellow")
                {
                    yellow++;
                    total += 15;
                }
                else if (color == "white")
                {
                    white++;
                    total += 20;
                }
                else if (color == "black")
                {
                    black++;
                    total /= 2;
                }
                else if (color != "red" && color != "yellow" && color != "orange"
                    && color != "white" && color != "black")
                {
                    others++;
                }
            }
            Console.WriteLine($"Total points: {total}");
            Console.WriteLine($"Points from red balls: {red}");
            Console.WriteLine($"Points from orange balls: {orange}");
            Console.WriteLine($"Points from yellow balls: {yellow}");
            Console.WriteLine($"Points from white balls: {white}");
            Console.WriteLine($"Other colors picked: {others}");
            Console.WriteLine($"Divides from black balls: {black}");
        }
    }
}
