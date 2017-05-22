namespace Sorting.Quicksort
{
    using System;

    public class Quicksort
    {
        private readonly int[] _array;
        private readonly int _length;

        public Quicksort(int[] array)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            _array = array;
            _length = _array.Length;
        }

        public void Sort()
        {
            if (_length <= 3)
                InsertionSort();
            else
                RecursiveQuicksort(0, _length - 1);
        }

        private void InsertionSort()
        {
            for (var i = 1; i < _length; i++)
            {
                var value = _array[i];
                var index = i;

                while (index > 0 && _array[index - 1] >= value)
                {
                    _array[index] = _array[index - 1];
                    index--;
                }

                _array[index] = value;
            }
        }

        private void RecursiveQuicksort(int left, int right)
        {
            if (IsEndOfIndex(left, right))
                return;

            var pivot = GetPivotValue(right);
            var partition = PartitionByPivot(left, right, pivot);

            SortLeftPart(left, partition);
            SortRightPart(right, partition);
        }

        private static bool IsEndOfIndex(int left, int right)
        {
            return right - left <= 0;
        }

        private int GetPivotValue(int right) => _array[right];

        private int PartitionByPivot(int left, int right, int pivot)
        {
            var leftPtr = left - 1;
            var rightPtr = right;

            while (true)
            {
                while (_array[++leftPtr] < pivot) ;

                while (rightPtr > 0 && _array[--rightPtr] > pivot) ;

                if (leftPtr >= rightPtr)
                    break;
                Swap(leftPtr, rightPtr);
            }

            Swap(leftPtr, right);
            return leftPtr;
        }

        private void Swap(int i, int j)
        {
            var temp = _array[i];
            _array[i] = _array[j];
            _array[j] = temp;
        }

        private void SortLeftPart(int left, int partition)
        {
            RecursiveQuicksort(left, partition - 1);
        }

        private void SortRightPart(int right, int partition)
        {
            RecursiveQuicksort(partition + 1, right);
        }
    }
}
