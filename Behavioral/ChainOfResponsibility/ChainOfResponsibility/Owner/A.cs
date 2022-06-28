using System;

namespace ChainOfResponsibility
{
    class A : Owner
    {
        public override void handleBaggage(Baggage baggage)
        {
            if (baggage is BaggageOfA)
            {
                Console.WriteLine($"{nameof(A)}의 수화물을 찾았습니다.");
                Console.WriteLine(baggage.ToString());
            }
            else
                base.handleBaggage(baggage);
        }
    }
}
