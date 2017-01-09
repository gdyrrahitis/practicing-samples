namespace Algorithm.Quicksort.Tests.QuicksortTests
{
    using System.Collections;
    using NUnit.Framework;
    using static NUnit.Framework.CollectionAssert;

    [TestFixture]
    public class Sort
    {
        [Test]
        public void DoesNotSortAnArrayOfOneElement()
        {
            // Arrange
            var array = new[] { 1 };
            var quickSort = new Quicksort(array);

            // Act
            quickSort.Sort();

            // Assert
            AreEqual(new[] { 1 }, array);
        }

        [Test]
        public void SortsTwoElementArrayWithInsertionSort()
        {
            // Arrange
            var array = new[] { 1, 0 };
            var quickSort = new Quicksort(array);

            // Act
            quickSort.Sort();

            // Assert
            AreEqual(new[] { 0, 1 }, array);
        }

        [Test]
        public void SortsThreeElementArrayWithInsertionSort()
        {
            // Arrange
            var array = new[] { 1, 0, 5 };
            var quickSort = new Quicksort(array);

            // Act
            quickSort.Sort();

            // Assert
            AreEqual(new[] { 0, 1, 5 }, array);
        }

        [Test]
        public void SortsFourElementArrayWithQuicksort()
        {
            // Arrange
            var array = new[] { 1, 0, 5, -8 };
            var quickSort = new Quicksort(array);

            // Act
            quickSort.Sort();

            // Assert
            AreEqual(new[] { -8, 0, 1, 5 }, array);
        }

        [Test]
        public void SortsFiveElementArrayWithQuicksort()
        {
            // Arrange
            var array = new[] { 1, 0, 5, -8, 45 };
            var quickSort = new Quicksort(array);

            // Act
            quickSort.Sort();

            // Assert
            AreEqual(new[] { -8, 0, 1, 5, 45 }, array);
        }

        [Test, TestCase(new [] { 0, 70, 6, 38, 38, 24, 56, 44, 26, 73, 77, 30, 45, 97, 65, 69 }, new [] { 0, 6, 24, 26, 30, 38, 38, 44, 45, 56, 65, 69, 70, 73, 77, 97 })]
        public void SortsTestCase(int[] array, int[] expected)
        {
            var quickSort = new Quicksort(array);

            // Act
            quickSort.Sort();

            // Assert
            AreEqual(expected, array);
        }
    }
}