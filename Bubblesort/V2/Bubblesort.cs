namespace Bubblesort.V2
{
    using System.Collections.Generic;

    public class Bubblesort
    {
        public IEnumerable<int> Sort(int[] v, Sort s = V2.Sort.Ascenting)
        {
            for (var i = 0; i < v.Length; i++)
            {
                for (var j = i + 1; j < v.Length; j++)
                {
                    if (s == V2.Sort.Ascenting)
                    {
                        if (v[i] > v[j])
                            Swap(v, j, i);
                    }
                    else
                        if (v[i] < v[j])
                            Swap(v, j, i);
                }
            }
            return v;
        }

        private void Swap(IList<int> v, int i, int j)
        {
            var temp = v[i];
            v[i] = v[j];
            v[j] = temp;
        }
    }

    public enum Sort
    {
        Ascenting, Descenting
    }
}
