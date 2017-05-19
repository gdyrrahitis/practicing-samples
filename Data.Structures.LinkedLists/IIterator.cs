namespace LinkedLists
{
    public interface IIterator
    {
        bool MoveNext();
        void Reset();
        Link Current { get; }
    }
}