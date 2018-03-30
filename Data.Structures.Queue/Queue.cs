namespace Data.Structures.Queue
{
    using System;
    using System.Collections;

    public class Queue : IEnumerable
    {
        private int _front;
        private int _back = -1;
        private readonly int[] _queue;

        public Queue(int size = 16)
        {
            _queue = new int[size];
        }

        public int Size => _back + 1;
        public bool IsEmpty => Size == 0;

        public void Push(int value)
        {
            if (++_back == _queue.Length)
            {
                _back--;
                throw new Exception("Queue is full");
            }

            _queue[_back] = value;
        }

        public void Empty()
        {
            _front = 0;
            _back = -1;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new QueueEnumerator(_queue, _back);
        }

        public int Pop()
        {
            if (_front > _back)
            {
                throw new Exception("Queue is empty");
            }

            return _queue[_front++];
        }
    }
}