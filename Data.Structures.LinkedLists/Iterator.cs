namespace Data.Structures.LinkedLists
{
    public class Iterator : IIterator
    {
        private readonly ILinkedList _list;

        public Iterator(ILinkedList list)
        {
            _list = list;
            _current = null;
        }

        private Link _current;
        public Link Current => _current?.GetType() == Link.Null.GetType() ? null : _current;

        public bool MoveNext()
        {
            if (_current == null)
            {
                if (_list.First == null)
                {
                    return false;
                }

                _current = _list.First;
            }
            else
            {
                if (_current.GetType() == Link.Null.GetType())
                {
                    return false;
                }

                if (_current.Next == null)
                {
                    _current = Link.Null;
                    return false;
                }

                _current = Current.Next;
            }

            return true;
        }

        public void Reset()
        {
            _current = _list.First;
        }
    }
}