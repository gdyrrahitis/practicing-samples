namespace Pivot
{
    public class Pivot
    {
        private readonly int[] _array;

        public Pivot(int[] array)
        {
            _array = array;
        }

        public int Partition(int left, int right, int pivot)
        {
            if (IsLengthLessOrEqualToTwo(_array))
                return -1;

            var leftPtr = left - 1;
            var rightPtr = right + 1;

            while (true)
            {
                while (leftPtr < right && _array[++leftPtr] < pivot) ;
                while (rightPtr > left && _array[--rightPtr] > pivot) ;

                if (leftPtr >= rightPtr)
                    break;

                Swap(leftPtr, rightPtr);
            }

            return leftPtr;
        }

        private void Swap(int left, int right)
        {
            var temp = _array[left];
            _array[left] = _array[right];
            _array[right] = temp;
        }

        private bool IsLengthLessOrEqualToTwo(int[] array)
        {
            return array.Length <= 2;
        }
    }
}