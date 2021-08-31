using System;

namespace Pool_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            double numPeople = double.Parse(Console.ReadLine());
            double entryFee = double.Parse(Console.ReadLine());
            double deckChair = double.Parse(Console.ReadLine());
            double umbrella = double.Parse(Console.ReadLine());

            double one = numPeople * entryFee;
            double two = Math.Ceiling(numPeople * 0.75) * deckChair;
            double three = Math.Ceiling(numPeople * 0.50) * umbrella;
            double final = one + two + three;
            Console.WriteLine($"{final:f2} lv.");
        }
    }
}
