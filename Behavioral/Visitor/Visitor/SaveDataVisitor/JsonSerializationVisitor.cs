using System;

namespace Visitor
{
    class JsonSerializationVisitor : SaveDataVisitor
    {
        public void visit(OptionSaveData data)
            => Console.WriteLine($"{data.detail} To Json");

        public void visit(GameSaveData data)
            => Console.WriteLine($"{data.detail} To Json");
    }
}
