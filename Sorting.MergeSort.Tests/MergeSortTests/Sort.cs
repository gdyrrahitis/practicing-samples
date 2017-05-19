namespace MergeSort.Tests.MergeSortTests
{
    using NUnit.Framework;

    [TestFixture]
    public class Sort
    {
        [TestCase(new[] { 2, 1, 5 })]
        [TestCase(new[] { 2, 1, 5, 9 })]
        [TestCase(new[] { 2, 1, 5, 9, 2, 5, 14 })]
        [TestCase(new[] { 77, -11, 0, 44, 99, 22, 88, 66, 55, 11, 33 })]
        public void Successfully(int[] array)
        {
            // Arrange
            var mergeSort = new MergeSort(array);

            // Act
            mergeSort.Sort();

            // Assert
            CollectionAssert.IsOrdered(array);
        }
    }
}