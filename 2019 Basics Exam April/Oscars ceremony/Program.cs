using System;

namespace Oscars_ceremony
{
    class Program
    {
        static void Main(string[] args)
        {
            int rent = int.Parse(Console.ReadLine());
            double figurine = rent * 0.70;
            double catering = figurine * 0.85;
            double sound = catering / 2;
            double final = rent + figurine + catering + sound;

            Console.WriteLine($"{final:f2}");

        }
    }
}
