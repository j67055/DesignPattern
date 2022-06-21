namespace Adapter
{
    class CData
    {
        private string data;

        public CData(string data)
            => this.data = data;

        public override string ToString()
            => data;
    }
}
