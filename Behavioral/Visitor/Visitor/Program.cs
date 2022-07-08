using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            SaveData optionData = new OptionSaveData("옵션 세이브");
            SaveData gameData = new GameSaveData("게임 세이브");

            optionData.accept(new JsonSerializationVisitor());
            gameData.accept(new BinarySerializationVisitor());
            gameData.accept(new XMLSerializationVisitor());
        }
    }
}
