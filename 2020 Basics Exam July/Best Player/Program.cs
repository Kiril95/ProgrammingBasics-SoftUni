using System;

namespace Best_Player
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = " ";
            string command = Console.ReadLine();
            int total = 0;

            while (command != "END")
            {
                int goals = int.Parse(Console.ReadLine());
                if (goals >= 10)
                {                    
                    total = goals;
                    name = command;
                    break;
                }
                if (goals > total)
                {
                    total = goals;
                    name = command;
                }
                command = Console.ReadLine(); 
            }
            Console.WriteLine($"{name} is the best player!");
            if (total >= 3)
            {
                Console.WriteLine($"He has scored {total} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {total} goals.");
            }

        }
    }
}
