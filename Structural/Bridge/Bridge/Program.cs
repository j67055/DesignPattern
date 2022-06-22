using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop bbq = new Shop(new BBQ());
            simuate("BBQ", bbq);

            Shop onlineHimart = new OnlineShop(new Himart());
            simuate("Online Himart", onlineHimart);
        }

        static void simuate(string title, Shop shop)
        {
            Console.WriteLine("**** " + title + " ****");
            shop.sell();
            shop.sell();
            shop.refund();
            shop.AS();
        }
    }
}
