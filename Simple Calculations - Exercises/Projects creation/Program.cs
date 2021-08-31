using System;

namespace Projects_creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());

            int final = projects * 3;

            Console.WriteLine($"The architect {name} will need {final} hours to complete {projects} project/s.");



        }
    }
}
