using System;

namespace Mediator
{
    class Speaker : HouseComponent
    {
        public Speaker(SmartHomeSystem mediator) : base(mediator) { }
        public void play(string alam)
            => Console.WriteLine(alam);
    }
}
