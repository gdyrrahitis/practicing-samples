namespace Sorting.MergeSort
{
    using System.Collections.Generic;

    public class MergeSort
    {
        private readonly int[] _array;

        public MergeSort(int[] array)
        {
            _array = array;
        }

        public void Sort()
        {
            var workspace = new int[_array.Length];
            RecursiveMergeSort(workspace, 0, _array.Length - 1);
        }

        private void RecursiveMergeSort(IList<int> workspace, int lowerBound, int upperBound)
        {
            // Pivot point
            if (lowerBound == upperBound)
                return;

            // Get mid
            var mid = (lowerBound + upperBound) / 2;

            // Sort recursively the lower part of the array
            RecursiveMergeSort(workspace, 0, mid);

            // Sort recursively the upper part of the array
            RecursiveMergeSort(workspace, mid + 1, upperBound);

            // Merge them
            Merge(workspace, lowerBound, mid + 1, upperBound);
        }

        private void Merge(IList<int> workspace, int lowPtr, int highPtr, int upperBound)
        {
            int j = 0,
                lowerBound = lowPtr,
                mid = highPtr - 1,
                length = upperBound - lowerBound + 1;

            // Sort upper and lower part
            while (lowPtr <= mid && highPtr <= upperBound)
            {
                if (_array[lowPtr] < _array[highPtr])
                    workspace[j++] = _array[lowPtr++];
                else
                    workspace[j++] = _array[highPtr++];
            }

            // If still haven't finished with lower part, do your job
            while (lowPtr <= mid)
            {
                workspace[j++] = _array[lowPtr++];
            }

            // If still haven't finished with upper part, do your job
            while (highPtr <= upperBound)
            {
                workspace[j++] = _array[highPtr++];
            }

            // Put workspace, which is sorted into the actual array
            for (j = 0; j < length; j++)
            {
                _array[lowerBound + j] = workspace[j];
            }
        }
    }
}