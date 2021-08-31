using System;

namespace Linking
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = Console.ReadLine();
            var last = Console.ReadLine();
            var age = Console.ReadLine();
            var town = Console.ReadLine();

            Console.WriteLine($"You are {first} {last}, a {age}-years old person from {town}.");

        }

    }
}
