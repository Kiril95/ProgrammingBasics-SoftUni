using System;

namespace Vacation_books_list
{
    class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            double pagesHour = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            double time = pages / pagesHour;
            double final = time / days;

            Console.WriteLine(final);

        }
    }
}
