namespace Observer
{
    interface Subject
    {
        void add(Observer observer);
        void remove(Observer observer);
        void notify();
    }
}
