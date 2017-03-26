namespace Sorting.InsertionSort
{
    public class InsertionSort
    {
        private readonly int[] _array;

        public InsertionSort(int[] array)
        {
            _array = array;
        }

        public void Sort()
        {
            for (var i = 0; i < _array.Length; i++)
            {
                var index = i;
                var value = _array[i];

                while (index > 0 && _array[index - 1] > value)
                {
                    _array[index] = _array[index - 1];
                    index--;
                }

                _array[index] = value;
            }
        }
    }
}