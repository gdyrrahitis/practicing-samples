namespace Bubblesort.V3
{
    public class BubbleSort
    {
        private readonly int[] _array;

        public BubbleSort(int[] array)
        {
            _array = array;
        }

        public void Sort()
        {
            var length = _array.Length - 1;
            for (var i = length; i > 0; i--)
                for (var j = 0; j < i; j++)
                    if (_array[i] < _array[j])
                        Swap(i, j);
        }

        private void Swap(int i, int j)
        {
            var temp = _array[i];
            _array[i] = _array[j];
            _array[j] = temp;
        }
    }
}