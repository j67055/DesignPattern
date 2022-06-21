namespace Adapter
{
    class Lightning8PinData
    {
        private string data;

        public Lightning8PinData(string data)
            => this.data = data;

        public override string ToString()
            => data;
    }
}
