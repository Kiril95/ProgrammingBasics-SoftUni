using System;

namespace Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Как се казваш?");
            //Console.WriteLine(" ");
            var name = Console.ReadLine();
            Console.WriteLine("Здрасти, {0}!", name);

        }
    }
}
