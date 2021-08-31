using System;

namespace Fish_tank
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenghtCm = int.Parse(Console.ReadLine());
            int widthCm = int.Parse(Console.ReadLine());
            int heightCm = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            int size = lenghtCm * widthCm * heightCm;
            double liters = size * 0.001;
            percent *= 0.01;
            double final = liters * (1 - percent);

            Console.WriteLine(final);
        }
    }
}
