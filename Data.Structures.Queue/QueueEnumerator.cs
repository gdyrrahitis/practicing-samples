namespace Data.Structures.Queue
{
    using System.Collections;

    public class QueueEnumerator : IEnumerator
    {
        private int _count = -1;
        private readonly int[] _queue;
        private readonly int _back;

        public QueueEnumerator(int[] queue, int back)
        {
            _queue = queue;
            _back = back;
        }

        public bool MoveNext() => ++_count <= _back;

        public void Reset() => _count = -1;

        public object Current => _queue[_count];
    }
}