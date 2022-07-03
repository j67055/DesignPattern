using System;
using System.Collections.Generic;
using System.Linq;

namespace Memento
{
    class Character
    {
        private Dictionary<string, Buff> buffs = new Dictionary<string, Buff>();

        public CharacterMemento createMemento()
            => new CharacterMemento(buffs.Keys.ToArray());

        public void setMemento(CharacterMemento memento)
            => buffs = memento.Buffs.ToDictionary(e => e, e => new Buff(e));

        public void addBuff(string buffName)
            => buffs.Add(buffName, new Buff(buffName));

        public void removeBuff(string buffName)
            => buffs.Remove(buffName);

        public void showBuffs()
        {
            Console.WriteLine("==========버프 목록==========");
            foreach (var buff in buffs.Values)
                Console.WriteLine("\t" + buff.ToString());
            Console.WriteLine("=============================");
        }
    }
}
