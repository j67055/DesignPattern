namespace ChainOfResponsibility
{
    class BaggageOfA : Baggage 
    {
        public override string ToString()
            => $"내용물: {nameof(A)}의 옷, {nameof(A)}의 돈";
    }
}
