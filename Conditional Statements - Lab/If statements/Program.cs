﻿using System;

namespace If_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else 
            {
                Console.WriteLine("odd");               
            }
        }
    }
}
