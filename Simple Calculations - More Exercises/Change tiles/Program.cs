using System;

namespace Change_tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            //Страна
            int N = int.Parse(Console.ReadLine());
            //Широчина на плочка
            double W = double.Parse(Console.ReadLine());
            //Дължина на плочка
            double L = double.Parse(Console.ReadLine());            
            //Широчина на пейка
            int M = int.Parse(Console.ReadLine());
            //Дължина на пейка
            int O = int.Parse(Console.ReadLine());

            int spaceGarden = N * N;
            int spaceBench = M * O;
            int repair = spaceGarden - spaceBench;
            double areaTile = W * L;
            double result = repair / areaTile;            
            double time = result * 0.2;

            Console.WriteLine(result);
            Console.WriteLine(time);           
        }
    }
}
