﻿using System;

namespace Fruit_or_vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine();

            if (n == "banana" || n == "apple" || n == "kiwi" || n == "cherry" 
                || n == "lemon" || n== "grapes")
            {
                Console.WriteLine("fruit");        
            }
            else if (n == "tomato" || n == "cucumber" || n == "pepper" || n == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
