using System;

namespace Animal_type
{
    class Program
    {
        static void Main(string[] args)
        {
            var animal = Console.ReadLine().ToLower();
            switch (animal)
            {
                case "dog": Console.WriteLine("mammal");break;
                case "crocodile": Console.WriteLine("reptile");break;
                case "tortoise": Console.WriteLine("reptile");break;
                case "snake": Console.WriteLine("reptile");break;
                
                default: case "others": Console.WriteLine("unknown"); break;
            }
        }
    }
}
