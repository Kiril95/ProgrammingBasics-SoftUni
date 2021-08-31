using System;

namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var sum = 0;

            while (sum < number)
            {
                int number2 = int.Parse(Console.ReadLine());               
                sum += number2;                             
            }
            Console.WriteLine(sum);

            //do
            //{
            //    number = int.Parse(Console.ReadLine());
            //    sum += number;
            //    
            //
            //} while (sum <= 100); 
            //Console.WriteLine(sum);


        }
    }
}
