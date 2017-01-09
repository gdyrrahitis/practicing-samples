namespace Bubblesort.V2
{
    using System.Collections.Generic;

    public class Bubblesort
    {
        public IEnumerable<int> Sort(int[] v, Sort s = V2.Sort.Ascenting)
        {
            for (int i = 0; i < v.Length; i++)
            {
                for (int j = i + 1; j < v.Length; j++)
                {
                    if (s == V2.Sort.Ascenting) {
                        if (v[i] > v[j])
                        {
                            var temp = v[j];
                            v[j] = v[i];
                            v[i] = temp;
                        }
                    }
                    else
                    {
                        if (v[i] < v[j])
                        {
                            var temp = v[j];
                            v[j] = v[i];
                            v[i] = temp;
                        }

                    }
                }
            }
            return v;
        }
    }

    public enum Sort {
        Ascenting, Descenting
    }
}
