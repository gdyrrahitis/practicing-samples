namespace Data.Structures.HashTable.Probing.Linear
{
    using System.Collections;
    using System.Collections.Generic;

    public class HashTable : IEnumerable<KeyValuePair<int, int>?>
    {
        private readonly int _size;
        private readonly KeyValuePair<int, int>?[] _hashTable;
        private static readonly KeyValuePair<int, int> NonItem = new KeyValuePair<int, int>(-1, -1);

        public HashTable(int size)
        {
            _size = size;
            _hashTable = new KeyValuePair<int, int>?[size];
        }

        public KeyValuePair<int, int>? Find(int key)
        {
            var hash = Hash(key);

            while (_hashTable[hash] != null)
            {
                if (_hashTable[hash].Value.Key == key)
                {
                    return _hashTable[hash];
                }

                hash++;
                hash %= _size;
            }

            return null;
        }

        private int Hash(int key) => key % _size;

        public void Insert(KeyValuePair<int, int> item)
        {
            var key = item.Key;
            var hash = Hash(key);

            while (_hashTable[hash] != null && _hashTable[hash].Value.Key != -1)
            {
                hash++;
                hash %= _size;
            }

            _hashTable[hash] = item;
        }

        public KeyValuePair<int, int>? Remove(int key)
        {
            var hash = Hash(key);

            while (_hashTable[hash] != null)
            {
                if (_hashTable[hash].Value.Value == key)
                {
                    var deleted = _hashTable[hash];
                    _hashTable[hash] = NonItem;
                    return deleted;
                }

                hash++;
                hash %= _size;
            }
            return null;
        }

        public IEnumerator<KeyValuePair<int, int>?> GetEnumerator()
        {
            var enumerator = _hashTable.GetEnumerator();
            while (enumerator.MoveNext())
            {
                yield return (KeyValuePair<int, int>?)enumerator.Current;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
