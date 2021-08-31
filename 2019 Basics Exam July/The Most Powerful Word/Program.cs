using System;

namespace The_Most_Powerful_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();           
            double letter = 0;
            string winnerWord = " ";
            double maxResult = -100000000;

            while (word != "End of words")
            {
                double letterSum = 0;
                double sum = 0;
                for (int i = 0; i < word.Length; i++)
                {
                    letter = word[0];
                    letterSum = letterSum + word[i];                  
                }
                if (letter == 'a' || letter == 'A' || letter == 'e' ||
                        letter == 'E' || letter == 'i' || letter == 'I' ||
                        letter == 'o' || letter == 'O' || letter == 'u' ||
                        letter == 'U' || letter == 'y' || letter == 'Y')
                {
                    sum = letterSum * word.Length;
                }
                else
                {
                    sum = Math.Floor(letterSum / word.Length);
                }
                if (sum > maxResult)
                {
                    maxResult = sum;
                    winnerWord = word;
                }

                word = Console.ReadLine();            

            }
            if (word == "End of words")
            {
                Console.WriteLine($"The most powerful word is {winnerWord} - {maxResult}");
            }
        }
    }
}
