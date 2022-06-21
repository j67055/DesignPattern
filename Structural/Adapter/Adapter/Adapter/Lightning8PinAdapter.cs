namespace Adapter
{
    class Lightning8PinAdapter : UsbType
    {
        private Lightning8PinType product;
        public Lightning8PinAdapter(Lightning8PinType product)
            => this.product = product;

        public UsbData getData()
        {
            Lightning8PinData data = product.getData();
            return new UsbData(data.ToString());
        }
    }
}
