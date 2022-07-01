namespace Iterator
{
    interface Iterator<T>
    {
        T Current { get; }

        void first();
        void next();
        bool isDone();
    }
}
