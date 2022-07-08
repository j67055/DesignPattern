using System;

namespace Visitor
{
    class XMLSerializationVisitor : SaveDataVisitor
    {
        public void visit(OptionSaveData data)
            => Console.WriteLine($"{data.detail} To XML");

        public void visit(GameSaveData data)
            => Console.WriteLine($"{data.detail} To XML");
    }
}
