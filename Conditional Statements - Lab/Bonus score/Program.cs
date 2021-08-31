using System;

class BonusScore
{
    static void Main()
    {
        double num = double.Parse(Console.ReadLine());
        double bonus = 0;

        if (num <= 100)
        {
            bonus += 5;
        }
        if (num > 100)
        {
            bonus = num * 0.20;
        }
        if (num > 1000)
        {
            bonus = num * 0.10;
        }
        if (num % 2 == 0)
        {
            bonus = bonus + 1;
        }
        if (num % 10 == 5) 
        {
            bonus = bonus + 2;
        }

        Console.WriteLine(bonus);
        Console.WriteLine(num + bonus);


    }
}
