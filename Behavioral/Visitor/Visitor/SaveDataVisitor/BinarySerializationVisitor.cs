using System;

namespace Visitor
{
    class BinarySerializationVisitor : SaveDataVisitor
    {
        public void visit(OptionSaveData data)
            => Console.WriteLine($"{data.detail} To Binary");

        public void visit(GameSaveData data)
            => Console.WriteLine($"{data.detail} To Binary");
    }
}
