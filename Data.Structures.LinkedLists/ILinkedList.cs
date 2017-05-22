namespace Data.Structures.LinkedLists
{
    public interface ILinkedList
    {
        Link First { get; }

        IIterator GetIterator();
        void Insert(int value);
        void Remove();
        bool HasAny();
        Link Find(int value);
    }
}