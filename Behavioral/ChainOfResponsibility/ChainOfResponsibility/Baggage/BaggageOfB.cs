namespace ChainOfResponsibility
{
    class BaggageOfB : Baggage 
    {
        public override string ToString()
        => $"내용물: {nameof(B)}의 옷, {nameof(B)}의 돈";
    }
}
