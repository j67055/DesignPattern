using System.Collections.Generic;
using System.Linq;

namespace Command
{
    class MacroCommand : Command
    {
        private List<Command> commands = new List<Command>();

        public void enqueue(Command command)
            => commands.Add(command);

        public Command dequeue()
        {
            Command last = commands.Last();
            commands.RemoveAt(commands.Count - 1);

            return last;
        }

        public void execute()
            => commands.ForEach(e => e.execute());

        public void unexecute()
        {
            for(int i = commands.Count - 1; i >= 0; --i)
                commands[i].unexecute();
        }
    }
}
