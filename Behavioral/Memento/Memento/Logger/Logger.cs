using System.Collections.Generic;

namespace Memento
{
    class Logger
    {
        private List<CharacterMemento> mementos = new List<CharacterMemento>();

        public void add(CharacterMemento memento)
            => mementos.Add(memento);

        public CharacterMemento get(int idx)
            => mementos[idx];
    }
}
