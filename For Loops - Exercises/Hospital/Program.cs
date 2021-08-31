using System;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());

            var treatedPatients = 0;
            var untreatedPatients = 0;
            var doctors = 7;

            for (int day = 1; day <= period; day++)
            {
                var currentPatient = int.Parse(Console.ReadLine());

                if ((day % 3 == 0) && (untreatedPatients > treatedPatients))
                {
                    doctors++;
                }
                if (currentPatient > doctors)
                {
                    treatedPatients += doctors;
                    untreatedPatients += currentPatient - doctors;
                }
                else
                {
                    treatedPatients += currentPatient;
                }
            }
            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {untreatedPatients}.");
        }
    }
}
