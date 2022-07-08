namespace Visitor
{
    interface SaveData
    {
        void accept(SaveDataVisitor visitor);
    }
}
