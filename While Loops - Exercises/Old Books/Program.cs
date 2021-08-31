using System;

namespace Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string nextBook = Console.ReadLine();
            int count = 0;

            while (nextBook != "No More Books")
            {
                if (nextBook == name)
                {
                    Console.WriteLine($"You checked {count} books and found it.");
                    return;
                }
                count++;
                nextBook = Console.ReadLine();

            }
            Console.WriteLine($"The book you search is not here!");
            Console.WriteLine($"You checked {count} books.");

        }
    }
}
