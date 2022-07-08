namespace Visitor
{
    class OptionSaveData : SaveData
    {
        public string detail { get; private set; }

        public OptionSaveData(string detail)
            => this.detail = detail;

        public void accept(SaveDataVisitor visitor)
            => visitor.visit(this);
    }
}
