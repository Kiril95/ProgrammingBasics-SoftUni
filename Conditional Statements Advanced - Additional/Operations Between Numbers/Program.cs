using System;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            string sign = Console.ReadLine();

            double division = num1 / num2;
            double module = num1 % num2;
            double summ = num1 + num2;
            double subtraction = num1 - num2;
            double multi = num1 * num2;

            if (num2 == 0 && (sign == "/" || sign == "%"))
            {
                Console.WriteLine($"Cannot divide {num1} by zero");
            }

            else if (sign == "/")
            {
                Console.WriteLine($"{num1} {sign} {num2} = {division:f2}");
            }
            else if (sign == "%")
            {
                Console.WriteLine($"{num1} {sign} {num2} = {module}");
            }

            if (sign == "+")
            {
                Console.WriteLine($"{num1} {sign} {num2} = {summ} - even");
            }
            else if (sign == "-")
            {
                Console.WriteLine($"{num1} {sign} {num2} = {subtraction} - odd");
            }
            else if (sign == "*")
            {
                Console.WriteLine($"{num1} {sign} {num2} = {multi} - odd");
            }

        }
    }
}

