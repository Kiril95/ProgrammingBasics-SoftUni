using System;

namespace Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var sum = 1;
            for (int row = 1; row <= num; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(sum + " ");
                    sum++;
                    if (sum > num)
                    {
                        break;
                    }                                    
                }
                Console.WriteLine();
                if (sum > num)
                {
                    break;
                }
            }
        }
    }
}
