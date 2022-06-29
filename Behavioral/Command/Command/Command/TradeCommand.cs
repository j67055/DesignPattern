using System;

namespace Command
{
    class TradeCommand : Command
    {
        private Trader buyer, seller;
        private string itemName;
        private bool isTradeCanceled;

        public TradeCommand(Trader buyer, Trader seller, string itemName)
        {
            this.buyer = buyer;
            this.seller = seller;
            this.itemName = itemName;
        }

        public void execute()
        {
            Item item = seller.getItem(itemName);

            Console.WriteLine("====================================================================================");

            if (item == null || !buyer.hasEnoughMoney(item.Price))
            {
                isTradeCanceled = true;

                Console.WriteLine("구매 실패");
                Console.WriteLine($"   판매자: {seller.Name}   구매자: {buyer.Name}  구매 풀품: {item.Name}  물품 가격: {item.Price.ToString()}\n");
                Console.WriteLine(seller);
                Console.WriteLine(buyer);
            }
            else
            {
                seller.removeItem(itemName);
                buyer.addItem(item);
                buyer.adjustMoney(-item.Price);
                seller.adjustMoney(item.Price);

                Console.WriteLine("구매 성공");
                Console.WriteLine($"   판매자: {seller.Name}   구매자: {buyer.Name}  구매 풀품: {item.Name}  물품 가격: {item.Price.ToString()}\n");
                Console.WriteLine(seller);
                Console.WriteLine(buyer);
            }
        }

        public void unexecute()
        {
            if (!isTradeCanceled)
            {
                Item item = buyer.getItem(itemName);

                buyer.removeItem(itemName);
                seller.addItem(item);
                seller.adjustMoney(-item.Price);
                buyer.adjustMoney(item.Price);
            }

            Console.WriteLine("====================================================================================");
            Console.WriteLine("되돌리기");
            Console.WriteLine(seller);
            Console.WriteLine(buyer);
        }
    }
}
