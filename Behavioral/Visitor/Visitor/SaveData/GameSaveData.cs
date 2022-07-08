namespace Visitor
{
    class GameSaveData : SaveData
    {
        public string detail { get; private set; }

        public GameSaveData(string detail)
            => this.detail = detail;

        public void accept(SaveDataVisitor visitor)
            => visitor.visit(this);
    }
}
