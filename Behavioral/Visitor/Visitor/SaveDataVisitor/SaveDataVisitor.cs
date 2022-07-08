namespace Visitor
{
    interface SaveDataVisitor
    {
        void visit(OptionSaveData data);
        void visit(GameSaveData data);
    }
}
