using System;

namespace Birthday_partyy
{
    class Program
    {
        static void Main(string[] args)
        {
            double rent = double.Parse(Console.ReadLine());

            double cake = rent * 0.20;
            double drinks = cake * 0.55;
            double animator = rent / 1 / 3;
            double total = rent + cake + drinks + animator;

            Console.WriteLine(total);

        }
    }
}
