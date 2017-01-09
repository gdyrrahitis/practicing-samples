namespace Bubblesort.V1
{
    using System;
    using System.Collections.Generic;

    public class Bubblesort
    {
        public IEnumerable<int> Sort(int[] array)
        {
            return SortArray(array, AscendingOrder());
        }

        public IEnumerable<int> Sort(int[] array, Order order)
        {
            switch (order)
            {
                case Order.Asc:
                    return Sort(array);
                case Order.Desc:
                    return SortArray(array, DescentingOrder());
                default:
                    throw new ArgumentOutOfRangeException(nameof(order), order, null);
            }
        }

        private IEnumerable<int> SortArray(int[] array, Func<int[], int, int, bool> predicate)
        {
            if (array == null) throw new ArgumentNullException(nameof(array));

            int i = 0,
                length = array.Length;

            for (; i < length; i++)
                for (var j = i; j < length; j++)
                    if (predicate(array, i, j))
                        Swap(array, i, j);

            return array;
        }

        private static Func<int[], int, int, bool> AscendingOrder()
        {
            return (a, i, j) => a[j] < a[i];
        }

        private static Func<int[], int, int, bool> DescentingOrder()
        {
            return (a, i, j) => a[j] > a[i];
        }

        private static void Swap(IList<int> array, int current, int next)
        {
            var temp = array[next];
            array[next] = array[current];
            array[current] = temp;
        }
    }

    public enum Order
    {
        Asc,
        Desc
    }
}
