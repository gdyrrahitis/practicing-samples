namespace Data.Structures.HashTable.Probing.Linear.Tests.HashTableTests
{
    using System.Collections.Generic;
    using System.Linq;
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

    [TestFixture]
    public class Enumerate
    {
        [TestCase(new[] { 3, 12 }, new[] { 200, 250 })]
        [TestCase(new[] { 11, 22, 33 }, new[] { 100, 90, 85 })]
        [TestCase(new[] { 66, 32, 14, 45 }, new[] { 100, 90, 85, 88 })]
        public void Successfully(int[] keys, int[] values)
        {
            // Arrange
            var hashTable = new HashTable(12);
            for (var i = 0; i < keys.Length; i++)
            {
                var keyValue = new KeyValuePair<int, int>(keys[i], values[i]);
                hashTable.Insert(keyValue);
            }

            // Act | Assert
            foreach (var key in keys)
            {
                True(hashTable.Any(x => x.HasValue && x.Value.Key == key));
            }
            AreEqual(keys.Length, hashTable.Count(x => x.HasValue));
            AreEqual(12 - keys.Length, hashTable.Count(x => !x.HasValue));
        }
    }
}