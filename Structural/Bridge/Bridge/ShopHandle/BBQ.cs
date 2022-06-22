namespace Bridge
{
    class BBQ : ShopHandle
    {
        public override int getDeliveryFee()
            => 4000;

        public override int getSalePrice()
            => 20000;

        public override bool isSupportAS()
         => false;
    }
}
