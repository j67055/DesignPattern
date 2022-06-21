namespace Adapter
{
    class UsbData
    {
        private string data;

        public UsbData(string data)
            => this.data = data;

        public override string ToString()
            => data;
    }
}
