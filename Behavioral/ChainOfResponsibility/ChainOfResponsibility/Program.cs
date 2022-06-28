using System.Collections.Generic;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Baggage> baggage = new List<Baggage>()
            {
                new BaggageOfA(),
                new BaggageOfB()
            };
            BaggageClaim baggageClaim = new BaggageClaim(baggage);
            baggageClaim.lineUp(new A());
            baggageClaim.lineUp(new B());

            baggageClaim.findBaggage();
        }
    }
}
