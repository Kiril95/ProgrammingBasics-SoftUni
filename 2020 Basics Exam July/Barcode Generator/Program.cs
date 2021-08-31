using System;

namespace Barcode_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            int f1 = first / 1000;
            int f2 = (first / 100) % 10;
            int f3 = (first / 10) % 10;
            int f4 = first % 10;

            int s1 = second / 1000;
            int s2 = (second / 100) % 10;
            int s3 = (second / 10) % 10;
            int s4 = second % 10;

            for (int i = f1; i <= s1; i++)
            {
                for (int j = f2; j <= s2;j++)
                {
                    for (int k = f3; k <= s3; k++)
                    {
                        for (int l = f4; l <= s4; l++)
                        {
                            if (i % 2 != 0 && j % 2 != 0 && k % 2 != 0 && l % 2 != 0)
                            {
                                Console.Write($"{i}{j}{k}{l} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
