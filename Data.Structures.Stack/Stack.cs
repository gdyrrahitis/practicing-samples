namespace Data.Structures.Stack
{
    using System;

    public class Stack
    {
        private readonly int[] _array;
        private int _current;

        public int Size
        {
            get
            {
                var count = 0;
                for (var i = _current + 1; i < _array.Length; i++)
                {
                    count++;
                }
                return count;
            }
        }

        public int Length => _array.Length;

        public Stack(int size = 16)
        {
            _array = new int[size];
            _current = size - 1;
        }

        public int PushAndPeek(int number)
        {
            if (_current - 1 >= 0)
            {
                Push(number);
                return number;
            }

            throw new Exception("Stack is full, cannot push.");
        }

        public void Push(int number)
        {
            _array[_current--] = number;
        }

        public int Peek()
        {
            if (_current == Length - 1) throw new Exception("Empty stack");

            return _array[_current + 1];
        }

        public int Pop()
        {
            return _array[++_current];
        }
    }
}
