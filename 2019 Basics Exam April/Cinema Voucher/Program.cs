using System;

namespace Cinema_Voucher
{
    class Program
    {
        static void Main(string[] args)
        {
            int voucher = int.Parse(Console.ReadLine());
            string purchase = Console.ReadLine();
            int movie = 0;
            int product = 0;
            int movieCount = 0;
            int productCount = 0;

            while (purchase != "End")
            {            
                if (purchase.Length > 8)
                {
                    movie = purchase[0] + purchase[1];                   
                    if (voucher < movie)
                    {
                        break;
                    }
                    voucher -= movie;
                    movieCount++;
                }
                else if (purchase.Length <= 8)
                {
                    product = purchase[0];                
                    if (voucher < product)
                    {
                        break;
                    }
                    voucher -= product;
                    productCount++;
                }              
                purchase = Console.ReadLine();
            }
            Console.WriteLine(movieCount);
            Console.WriteLine(productCount);
        }
    }
}
