using System;

namespace Vowels_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            var summ = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a')
                {
                    summ += 1;
                }
                else if (s[i] == 'e')
                {
                    summ += 2;
                }
                else if (s[i] == 'i')
                {
                    summ += 3;
                }
                else if (s[i] == 'o')
                {
                    summ += 4;
                }
                else if (s[i] == 'u')
                {
                    summ += 5;
                }
            
            Console.WriteLine(summ);
        }
    }
}
