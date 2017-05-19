# Shellsort

Took its name from [Donald L. Shell](https://en.wikipedia.org/wiki/Donald_Shell) who proposed the algorithm back at 1959.
It is based on insertion sort algorithm, though it adds one characteristic that improves the algorithm's overall performance.

Algorithm is based on Knuth's sequence, which creates gaps between elements. This is the secret sauce of the algorithm, using insertion sort
under the wraps to sort elements that are away (have significant gaps) from each other. We then sort each subgroup (we essentially break the array into subgroups, which can be sorted individually using insertion sort).

### Description of the algorithm
Start from `h = 1` and implement the Knuth sequence (see below) to create a sequence of 1, 4, 13, 40, 121, 364,...
Increase `h` using the Knuth's formula until `h > array.length / 3`.
Then, as long as  `h > 0`, implement insertion sort on the array, going as far as `h` each time, decreasing `h` value after a successful sort of an individual subgroup.

Note: Let's assume that 3 is the gap number.

Knuth sequence
```
h = h * 3 + 1
```

Decreasing sequence on each loop
```
h = (h - 1) / 3
```

Full algorithm sample:
```
        private const int KnuthConstant = 3;

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
```