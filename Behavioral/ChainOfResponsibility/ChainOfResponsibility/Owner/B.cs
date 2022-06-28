using System;

namespace ChainOfResponsibility
{
    class B : Owner
    {
        public override void handleBaggage(Baggage baggage)
        {
            if (baggage is BaggageOfB)
            {
                Console.WriteLine($"{nameof(B)}의 수화물을 찾았습니다.");
                Console.WriteLine(baggage.ToString());
            }
            else
             base.handleBaggage(baggage);
        }
    }
}
