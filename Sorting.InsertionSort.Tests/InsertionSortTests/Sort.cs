namespace Sorting.InsertionSort.Tests.InsertionSortTests
{
    using NUnit.Framework;

    [TestFixture]
    public class Sort
    {
        [TestCase(new[] {9, 1, 10})]
        [TestCase(new[] { 77, 99, 44, 55, 22, 88, 11, 0, 66, 33 })]
        public void ArraySuccessfully(int[] array)
        {
            // Arrange
            var insertionSort = new InsertionSort(array);

            // Act
            insertionSort.Sort();

            // Assert
            CollectionAssert.IsOrdered(array);
        }
    }
}