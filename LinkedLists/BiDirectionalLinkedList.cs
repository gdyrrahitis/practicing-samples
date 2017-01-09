namespace LinkedLists
{
    public class BiDirectionalLinkedList : LinkedList, IBiDirectionalLinkedList
    {
        public Link Last { get; protected set; }

        public virtual void Append(int value)
        {
            var link = new Link(value);
            if (IsEmpty())
            {
                First = link;
            }
            else
            {
                Last.Next = link;
            }
            Last = link;
        }

        private bool IsEmpty()
        {
            return !HasAny();
        }

        public override void Remove()
        {
            if (IsEmpty())
                return;

            if (First.Next == null)
            {
                Last = null;
            }

            First = First.Next;
        }
    }
}