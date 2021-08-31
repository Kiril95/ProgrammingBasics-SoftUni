using System;

namespace _2020_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoin = int.Parse(Console.ReadLine());
            double yuan = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());

            bitcoin *= 1168;
            yuan *= 0.15;
            double dollar = yuan * 1.76;
            double euro = (bitcoin + dollar) / 1.95;
            double commis = euro * commission / 100;
            double final = euro - commis;

            Console.WriteLine($"{final:f2}");
        }
    }
}
