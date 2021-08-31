using System;

namespace Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            while (true)
            {
                try
                {
                    num = int.Parse(Console.ReadLine());
                    if (num % 2 == 0)
                    {
                        break;
                    }
                    Console.WriteLine("The number is not even.");
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid number!");
                }               
            }
            Console.WriteLine($"Even number entered: {num}");

        }
    }
}
