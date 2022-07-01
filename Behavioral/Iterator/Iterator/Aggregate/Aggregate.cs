namespace Iterator
{
    interface Aggregate<T>
    {
        Iterator<T> createIterator();
    }
}
