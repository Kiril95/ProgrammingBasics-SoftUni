using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int people = 0;
            int sum = 0;
            int total = 0;
            int counter = 0;

            while (command != "Movie time!")
            {
                people = int.Parse(command);
                sum = people * 5;
                total += sum;
                capacity -= people;
                //counter += people;
                if (people % 3 == 0)
                {
                    total -= 5;
                }
                if (capacity <= 0)
                {
                    //Console.WriteLine("The cinema is full.");
                    //Console.WriteLine($"Cinema income - {total} lv.");
                    break;
                }
                command = Console.ReadLine();

            }
            if (capacity > 0 || capacity == 0)
            {
                Console.WriteLine($"There are {capacity} seats left in the cinema.");
            }
            else
            {
                Console.WriteLine("The cinema is full.");
            }
            
            Console.WriteLine($"Cinema income - {total} lv.");

        }
    }
}
