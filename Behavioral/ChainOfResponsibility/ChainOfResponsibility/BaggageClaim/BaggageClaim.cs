using System.Collections.Generic;

namespace ChainOfResponsibility
{
    class BaggageClaim
    {
        private Queue<Baggage> conveyorBelt;
        private Line line;

        public BaggageClaim(List<Baggage> baggage)
        {
            conveyorBelt = new Queue<Baggage>(baggage);
            line = new Line();
        }

        public void lineUp(Owner owner)
            => line.lineUp(owner);

        public void findBaggage()
        {
            while (conveyorBelt.Count > 0)
                line.Head.handleBaggage(conveyorBelt.Dequeue());
        }

    }
}
