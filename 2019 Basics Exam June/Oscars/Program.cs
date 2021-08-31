using System;

namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actor = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int judges = int.Parse(Console.ReadLine());

            double sum = points;

            for (int i = 0; i < judges; i++)
            {
                string actorJudge = Console.ReadLine();
                double pointsJudge = double.Parse(Console.ReadLine());

                sum += (actorJudge.Length * pointsJudge) / 2;
                //if (sum < 351)
                //{
                //    sum = sum + points;
                //}
                if (sum >= 1250.5)
                {
                    break;
                }              

            }
            if (sum >= 1250.5 )
            {
                Console.WriteLine($"Congratulations, {actor} got a nominee " +
                    $"for leading role with {sum:f1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {actor} you need {Math.Abs(sum - 1250.5):f1} more!");
            }

        }
    }
}
