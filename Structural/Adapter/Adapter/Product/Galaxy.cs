namespace Adapter
{
    class Galaxy : CType
    {
        private string model;

        public Galaxy(string model)
            => this.model = model;

        public CData getData()
            => new CData(model);
    }
}
