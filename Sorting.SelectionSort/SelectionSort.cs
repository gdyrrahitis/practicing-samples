namespace Sorting.SelectionSort
{
    public class SelectionSort
    {
        private readonly int[] _array;
        private readonly int _length;

        public SelectionSort(int[] array)
        {
            _array = array;
            _length = _array.Length;
        }

        public void Sort()
        {
            for (var i = 0; i < _length - 1; i++)
            {
                var minIndex = i;
                for (var j = i + 1; j < _length; j++)
                    if (_array[minIndex] > _array[j])
                        minIndex = j;

                Swap(i, minIndex);
            }
        }

        private void Swap(int i, int j)
        {
            var temp = _array[i];
            _array[i] = _array[j];
            _array[j] = temp;
        }
    }
}