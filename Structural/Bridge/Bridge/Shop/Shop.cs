using System;

namespace Bridge
{
    class Shop
    {
        protected ShopHandle handle;
        protected int money;

        public Shop(ShopHandle handle)
            => this.handle = handle;

        public virtual void sell()
        {
            var price = handle.getSalePrice();
            money += price;

            Console.WriteLine("판매 내역");
            Console.WriteLine("     판매 +" + price.ToString());
            Console.WriteLine("총 매출액: " + money.ToString());
            Console.WriteLine();
        }

        public virtual void refund()
        {
            var price = handle.getSalePrice();
            money -= price;

            Console.WriteLine("환불 내역");
            Console.WriteLine("     환불 -" + price.ToString());
            Console.WriteLine("총 매출액: " + money.ToString());
            Console.WriteLine();
        }

        public void AS()
        {
            if (handle.isSupportAS())
                Console.WriteLine("AS 완료");
            else
                Console.WriteLine("AS를 지원하지 않습니다.");
            Console.WriteLine();
        }
    }
}
