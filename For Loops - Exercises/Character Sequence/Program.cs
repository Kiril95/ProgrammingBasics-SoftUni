using System;

namespace Character_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int letter = 0; letter < input.Length; letter++)
            {
                Console.Write(input[letter]);
            }
        }
    }
}
