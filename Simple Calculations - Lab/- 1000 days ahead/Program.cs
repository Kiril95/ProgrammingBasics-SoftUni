using System;
using System.Globalization;

namespace __1000_days_ahead
{
    class Program
    {
        static void Main(string[] args)
        {
            var String = Console.ReadLine();
            var format = "dd-MM-yyyy";
            var Date = DateTime.ParseExact(String, format, CultureInfo.InvariantCulture);
            Date = Date.AddDays(999);
            Console.WriteLine(Date.ToString(format));
        }
    }
}
