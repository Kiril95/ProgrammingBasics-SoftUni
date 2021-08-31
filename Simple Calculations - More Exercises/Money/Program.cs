using System;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoin = int.Parse(Console.ReadLine());
            double yuan = double.Parse(Console.ReadLine());
            double commis = double.Parse(Console.ReadLine());

            bitcoin = bitcoin * 1168;
            yuan = yuan * 0.15;
            double dollarLev = yuan * 1.76;

            double Lev = bitcoin + dollarLev;
            double Euro = Lev / 1.95;

            double commision = Euro * commis / 100;
            double final = Euro - commision;
            Console.WriteLine(final);

        }
    }
}
