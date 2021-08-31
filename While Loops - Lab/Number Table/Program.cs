using System;

namespace Number_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int row = 0; row < num; row++)
            {
                for (int col = 0; col < num; col++)
                {
                    var result = row + col + 1;
                    if (result > num)
                    {
                        result = 2 * num - result;
                    }
                    Console.Write(result + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
