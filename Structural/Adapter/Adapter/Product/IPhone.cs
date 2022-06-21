namespace Adapter
{
    class IPhone : Lightning8PinType
    {
        private string model;

        public IPhone(string model)
            => this.model = model;

        public Lightning8PinData getData()
            => new Lightning8PinData(model);
    }
}
