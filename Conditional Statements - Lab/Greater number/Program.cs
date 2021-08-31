using System;

namespace Greater_number
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("Greater: " + num1);
            }
            else 
            {
                Console.WriteLine("Greater: " + num2);
            }
        }
    }
}
