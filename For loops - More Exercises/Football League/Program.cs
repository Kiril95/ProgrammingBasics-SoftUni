using System;

namespace Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            double stadium = double.Parse(Console.ReadLine());
            double ultras = double.Parse(Console.ReadLine());

            var A = 0.0;
            var B = 0.0;
            var V = 0.0;
            var G = 0.0;
            var all = 0.0;

            for (int i = 0; i < ultras; i++)
            {
                string sector = Console.ReadLine();

                if (sector == "A")
                {
                    A++;
                }
                if (sector == "B")
                {
                    B++;
                }
                if (sector == "V")
                {
                    V++;
                }
                if (sector == "G")
                {
                    G++;
                }                              
            }
            A = (A / ultras) * 100;
            B = (B / ultras) * 100;
            V = (V / ultras) * 100;
            G = (G / ultras) * 100;
            all = (ultras / stadium) * 100;

            Console.WriteLine($"{A:f2}%");
            Console.WriteLine($"{B:f2}%");
            Console.WriteLine($"{V:f2}%");
            Console.WriteLine($"{G:f2}%");
            Console.WriteLine($"{all:f2}%");
        }
    }
}
