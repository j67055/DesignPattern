namespace Adapter
{
    class CAdapter : UsbType
    {
        private CType product;

        public CAdapter(CType product)
            => this.product = product;

        public UsbData getData()
        {
            CData data = product.getData();
            return new UsbData(data.ToString());
        }
    }
}
