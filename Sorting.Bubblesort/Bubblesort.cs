namespace Sorting.Bubblesort
{
    public class Bubblesort
    {
        private readonly int[] _array;

        public Bubblesort(int[] array)
        {
            _array = array;
        }

        public void Sort()
        {
            for (var i = _array.Length - 1; i >= 0; i--)
                for (var j = 0; j < i; j++)
                    if (_array[j] > _array[j + 1])
                        Swap(j, j + 1);
        }

        private void Swap(int i, int j)
        {
            var temp = _array[j];
            _array[j] = _array[i];
            _array[i] = temp;
        }
    }
}