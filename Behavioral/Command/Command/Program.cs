using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Trader shop = new Trader("상점");
            shop.adjustMoney(1000);
            shop.addItem(new Item("체력 포션", 10));
            shop.addItem(new Item("마나 포션", 15));
            shop.addItem(new Item("롱 소드", 100));
            Trader customer = new Trader("고객");
            customer.adjustMoney(100);
            customer.addItem(new Item("활", 50));

            MacroCommand commands = new MacroCommand();
            commands.enqueue(new TradeCommand(customer, shop, "체력 포션"));
            commands.enqueue(new TradeCommand(customer, shop, "롱 소드"));
            commands.enqueue(new TradeCommand(shop, customer, "활"));
            commands.enqueue(new TradeCommand(customer, shop, "롱 소드"));

            Console.WriteLine("초기값");
            Console.WriteLine(shop);
            Console.WriteLine(customer);

            commands.execute();
            commands.unexecute();
        }
    }
}
