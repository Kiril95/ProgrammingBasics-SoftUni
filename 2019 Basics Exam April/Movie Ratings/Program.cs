using System;

namespace Movie_Ratings
{
    class Program
    {
        static void Main(string[] args)
        {
            int movies = int.Parse(Console.ReadLine());
            var highest = 0.0;
            var lowest = 10.0;
            var average = 0.0;
            var total = 0.0;
            string nameHighest = " ";
            string nameLowest = " ";

            for (int i = 0; i < movies; i++)
            {
                string name = Console.ReadLine();
                double ratings = double.Parse(Console.ReadLine());

                total += ratings;
                if (ratings > highest)
                {
                    highest = ratings;
                    nameHighest = name;
                }
                else if (ratings < lowest)
                {
                    lowest = ratings;
                    nameLowest = name;
                }
            }
            average = total / movies;
            Console.WriteLine($"{nameHighest} is with highest rating: {highest:f1}");
            Console.WriteLine($"{nameLowest} is with lowest rating: {lowest:f1}");
            Console.WriteLine($"Average rating: {average:f1}");
        }
    }
}
