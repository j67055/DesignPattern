namespace Bridge
{
    class Himart : ShopHandle
    {
        public override int getDeliveryFee()
            => 20000;

        public override int getSalePrice()
            => 10000000;

        public override bool isSupportAS()
            => true;
    }
}
