using System;

namespace Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int group = int.Parse(Console.ReadLine());

            double Musala = 0;
            double Montblanc = 0;
            double Kilimanjaro = 0;
            double Ktwo = 0;
            double Everest = 0;

            for (int i = 0; i < group; i++)
            {
                int people = int.Parse(Console.ReadLine());

                if (people <= 5)
                {
                    Musala += people;
                }
                if (people >= 6 && people <= 12)
                {
                    Montblanc += people;
                }
                if (people >= 13 && people <= 25)
                {
                    Kilimanjaro += people;
                }
                if (people >= 26 && people <= 40)
                {
                    Ktwo += people;
                }
                if (people >= 41)
                {
                    Everest += people;
                }
            }
            double total = Musala + Montblanc + Kilimanjaro + Ktwo + Everest;
            Musala = (Musala / total) * 100;
            Montblanc = (Montblanc / total) * 100;
            Kilimanjaro = (Kilimanjaro / total) * 100;
            Ktwo = (Ktwo / total) * 100;
            Everest = (Everest / total) * 100;

            Console.WriteLine($"{Musala:f2}%");
            Console.WriteLine($"{Montblanc:f2}%");
            Console.WriteLine($"{Kilimanjaro:f2}%");
            Console.WriteLine($"{Ktwo:f2}%");
            Console.WriteLine($"{Everest:f2}%");
        }
    }
}
