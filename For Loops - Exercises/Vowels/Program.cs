using System;

namespace Vowels_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string letter = Console.ReadLine();
            var summ = 0;

            for (int i = 0; i < letter.Length; i++)
            {
                if (letter[i] == 'a')
                {
                    summ += 1;
                }
                else if (letter[i] == 'e')
                {
                    summ += 2;
                }
                else if (letter[i] == 'i')
                {
                    summ += 3;
                }
                else if (letter[i] == 'o')
                {
                    summ += 4;
                }
                else if (letter[i] == 'u')
                {
                    summ += 5;
                }

                Console.WriteLine(summ);
            }
        }
    }

}   
