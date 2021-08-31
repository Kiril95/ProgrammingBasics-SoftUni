using System;

namespace Sentence_using___
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи име ");
            var firstName = Console.ReadLine();
            Console.Write("Въведи фамилия ");
            var lastName = Console.ReadLine();
            Console.Write("Години ");
            var age = int.Parse(Console.ReadLine());
            Console.Write("Град ");
            var town = Console.ReadLine();
            Console.WriteLine("Ти си {0} {1}, {2}-годишен човек от {3}.", firstName, lastName, age, town);
           
        }
    }
}
