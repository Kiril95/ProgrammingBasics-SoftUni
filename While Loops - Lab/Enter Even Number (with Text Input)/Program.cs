using System;

namespace Enter_Even_Number__with_Text_Input_
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    int num = int.Parse(Console.ReadLine());
                    if (num % 2 == 0)
                    {
                        Console.WriteLine($"Even number is: {num}");
                        break;
                    }
                    Console.WriteLine("Enter even number, please.");
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid!");
                }              
            }
          
        }
    }
}
