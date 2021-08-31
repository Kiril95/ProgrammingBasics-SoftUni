﻿using System;

class Program
{
    static void Main(string[] args)
    {
        int hours = int.Parse(Console.ReadLine());
        int mins = int.Parse(Console.ReadLine());

        mins += 15;

        if (mins >= 60)
        {
            hours += 1;
            mins -= 60;
        }

        if (hours == 24)
        {
            hours = 0;
        }

        Console.WriteLine("{0}:{01:00}", hours, min);
    }
}
