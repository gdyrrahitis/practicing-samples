namespace Sorting.Shellsort
{
    public class Shellsort
    {
        private readonly int[] _array;
        private const int KnuthConstant = 3;

        public Shellsort(int[] array)
        {
            _array = array;
        }

        public int KnuthSequence(int h)
        {
            return KnuthConstant * h + 1;
        }

        public void Sort()
        {
            var h = 1;
            while (h <= _array.Length / KnuthConstant)
            {
                h = KnuthSequence(h);
            }

            while (h > 0)
            {
                for (var i = h; i < _array.Length; i++)
                {
                    var value = _array[i];
                    var inner = i;

                    while (inner > h - 1 && _array[inner - h] > value)
                    {
                        _array[inner] = _array[inner - h];
                        inner -= h;
                    }

                    _array[inner] = value;
                }

                h = (h - 1) / KnuthConstant;
            }
        }
    }
}