# Bubblesort

The simplest of the sorting algorithms.
It's complexity is O(N^2) in the worst case scenario.
Average number of comparisons in this algorithm is N/2

In this algorithm, you compare the current element with the next in the array. If the current element is less than the next then you swap them.
This continues until all elements in the array are ordered.

Following example shows the bubblesort algorithm implementation, sorting an array in ascending order.

```
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
```