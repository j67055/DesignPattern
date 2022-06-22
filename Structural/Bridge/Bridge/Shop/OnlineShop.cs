using System;

namespace Bridge
{
    class OnlineShop : Shop
    {
        public OnlineShop(ShopHandle handle) : base(handle) { }

        public override void sell()
        {
            var salePrice = handle.getSalePrice();
            var deleveryFee = handle.getDeliveryFee();
            money += salePrice + deleveryFee;

            Console.WriteLine("판매 내역");
            Console.WriteLine("     판매 +" + salePrice.ToString());
            Console.WriteLine("     배달 +" + deleveryFee.ToString());
            Console.WriteLine("총 매출액: " + money.ToString());
            Console.WriteLine();
        }

        public override void refund()
        {
            var salePrice = handle.getSalePrice();
            var deleveryFee = handle.getDeliveryFee();
            money -= salePrice + deleveryFee;

            Console.WriteLine("환불 내역");
            Console.WriteLine("     환불 -" + salePrice.ToString());
            Console.WriteLine("     배달 -" + deleveryFee.ToString());
            Console.WriteLine("총 매출액: " + money.ToString());
            Console.WriteLine();
        }
    }
}
