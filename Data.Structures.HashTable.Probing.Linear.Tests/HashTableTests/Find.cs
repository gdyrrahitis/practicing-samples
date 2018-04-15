namespace Data.Structures.HashTable.Probing.Linear.Tests.HashTableTests
{
    using System.Collections.Generic;
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

    [TestFixture]
    public class Find
    {
        [TestCase(new[] {3, 12}, new[] {200, 250}, 12, 12)]
        [TestCase(new[] {11, 22, 33}, new[] {100, 90, 85}, 11, 11)]
        [TestCase(new[] {66, 32, 14, 45}, new[] {100, 90, 85, 88}, 14, 14)]
        [TestCase(new[] {66, 32, 14, 45}, new[] {100, 90, 85, 88}, 90, null)]
        public void Successfully(int[] keys, int[] values, int key, int? expected)
        {
            // Arrange
            var hashTable = new HashTable(12);
            for (var i = 0; i < keys.Length; i++)
            {
                var keyValue = new KeyValuePair<int, int>(keys[i], values[i]);
                hashTable.Insert(keyValue);
            }

            // Act
            var result = hashTable.Find(key);

            // Assert
            if (expected.HasValue)
            {
                AreEqual(expected, result?.Key);
            }
            else
            {
                Null(result);
            }
        }

        [Test]
        public void ReturnsNullWhenHashTableHasNotBeenInitializedWithValues()
        {
            // Arrange

            // Act

            // Assert
        }
    }
}