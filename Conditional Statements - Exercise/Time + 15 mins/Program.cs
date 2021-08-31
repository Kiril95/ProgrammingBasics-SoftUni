using System;

namespace Time___15_mins
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            var totalMin = minutes + 15;
            var allHours = hour + totalMin / 60;
            var allMinutes = totalMin % 60;

            if (allHours == 24)
            {
                Console.WriteLine("0:{0:00}", allMinutes);
            }
            else
            {
                Console.WriteLine("{0}:{1:00}", allHours, allMinutes);
            }
        }
    }
}
