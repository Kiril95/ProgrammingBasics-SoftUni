using System;

namespace abc
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number >= 0 && number <= 19)
            {
                switch (number)
                {
                    case 0: Console.WriteLine("zero"); break;
                    case 1: Console.WriteLine("one"); break;
                    case 2: Console.WriteLine("two"); break;
                    case 3: Console.WriteLine("three"); break;
                    case 4: Console.WriteLine("four"); break;
                    case 5: Console.WriteLine("five"); break;
                    case 6: Console.WriteLine("six"); break;
                    case 7: Console.WriteLine("seven"); break;
                    case 8: Console.WriteLine("eight"); break;
                    case 9: Console.WriteLine("nine"); break;
                    case 10: Console.WriteLine("ten"); break;
                    case 11: Console.WriteLine("eleven"); break;
                    case 12: Console.WriteLine("twelve"); break;
                    case 13: Console.WriteLine("thirteen"); break;
                    case 14: Console.WriteLine("fourteen"); break;
                    case 15: Console.WriteLine("fifteen"); break;
                    case 16: Console.WriteLine("sixteen"); break;
                    case 17: Console.WriteLine("seventeen"); break;
                    case 18: Console.WriteLine("eighteen"); break;
                    case 19: Console.WriteLine("nineteen"); break;
                }
            }
            else if (number >= 20 && number <= 99)
            {
                int dozens = number / 10;
                int singulars = number % 10;

                switch (dozens)
                {
                    case 2: Console.WriteLine("twenty"); break;
                    case 3: Console.WriteLine("thirty"); break;
                    case 4: Console.WriteLine("forty"); break;
                    case 5: Console.WriteLine("fifty"); break;
                    case 6: Console.WriteLine("sixty"); break;
                    case 7: Console.WriteLine("seventy"); break;
                    case 8: Console.WriteLine("eighty"); break;
                    case 9: Console.WriteLine("ninety"); break;
                }

                switch (singulars)
                {
                    case 1: Console.WriteLine("one"); break;
                    case 2: Console.WriteLine("two"); break;
                    case 3: Console.WriteLine("three"); break;
                    case 4: Console.WriteLine("four"); break;
                    case 5: Console.WriteLine("five"); break;
                    case 6: Console.WriteLine("six"); break;
                    case 7: Console.WriteLine("seven"); break;
                    case 8: Console.WriteLine("eight"); break;
                    case 9: Console.WriteLine("nine"); break;
                }
            }
            else if (number == 100)
            {
                Console.WriteLine("one hundred");
            }
            else
            {
                Console.WriteLine("invalid number");
            }
        }
    }
}
