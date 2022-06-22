namespace Bridge
{
    class Kyobo : ShopHandle
    {
        public override int getDeliveryFee()
            => 0;

        public override int getSalePrice()
            => 25000;

        public override bool isSupportAS()
         => false;
    }
}
