namespace ChainOfResponsibility
{
    abstract class BaggageHandler
    {
        private BaggageHandler successor;

        public void setSuccessor(BaggageHandler successor)
            => this.successor = successor;

        public virtual void handleBaggage(Baggage baggage)
            => successor?.handleBaggage(baggage);
    }
}
