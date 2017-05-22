namespace Data.Structures.LinkedLists
{
    public class LinkedList : ILinkedList
    {
        public LinkedList()
        {
            First = null;
        }

        public Link First { get; protected set; }

        public bool HasAny()
        {
            return First != null;
        }

        public Link Find(int value)
        {
            var iterator = GetIterator();
            while (iterator.MoveNext())
            {
                if (iterator.Current.Value == value)
                    return iterator.Current;
            }

            return null;
        }

        public virtual IIterator GetIterator()
        {
            return new Iterator(this);
        }

        public virtual void Insert(int value)
        {
            var link = new Link(value);
            if (First == null)
            {
                First = link;
            }
            else
            {
                link.Next = First;
                First = link;
            }
        }

        public virtual void Remove()
        {
            First = First?.Next;
        }
    }
}