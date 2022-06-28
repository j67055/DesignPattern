namespace ChainOfResponsibility
{
    class Line
    {
        public Owner Head => head;

        private Owner head, tail;

        public void lineUp(Owner owner)
        {
            if(head == null)
                head = tail = owner;

            tail.setSuccessor(owner);
        }
    }
}
