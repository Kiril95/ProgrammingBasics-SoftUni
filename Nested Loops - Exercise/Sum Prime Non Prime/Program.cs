using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            bool isNumber = false;
            int number = 0;
            int sumPrime = 0;
            int sumNonPrime = 0;
            bool isNonPrime = false;
            while (input != "stop")
            {
                isNonPrime = false;
                input = Console.ReadLine();
                isNumber = int.TryParse(input, out number);
                if (isNumber == true)
                {
                    if (number < 0)
                    {
                        Console.WriteLine("Number is negative.");
                        continue;
                    }
                    if (number == 0 || number == 1)
                    {
                        isNonPrime = true;
                    }
                    for (int i = 2; i < number; i++)
                    {
                        if (number % i == 0 && i != number)  //Check for Non prime number
                        {
                            isNonPrime = true;
                            break;
                        }
                    }
                    if (isNonPrime == true)
                    {
                        sumNonPrime += number;
                    }
                    else
                    {
                        sumPrime += number;
                    }
                }
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
        }
    }
}