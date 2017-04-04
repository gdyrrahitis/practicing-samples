namespace Algorithm.Shellsort.Tests.Unit.ShellsortTests
{
    using NUnit.Framework;
    using static NUnit.Framework.CollectionAssert;

    [TestFixture]
    public class Sort
    {
        [TestCase(new [] {1})]
        public void DoesNotSortSingleElementArray(int[] array)
        {
            // Arrange
            var shellSort = new Shellsort(array);

            // Act
            shellSort.Sort();

            // Assert
            IsOrdered(array);
        }

        [TestCase(new[] { 10, 5 })]
        public void SortsTwoElementsArray(int[] array)
        {
            // Arrange
            var shellSort = new Shellsort(array);

            // Act
            shellSort.Sort();

            // Assert
            IsOrdered(array);
        }

        [TestCase(new[] { 10, 5, 6 })]
        public void SortsThreeElementsArray(int[] array)
        {
            // Arrange
            var shellSort = new Shellsort(array);

            // Act
            shellSort.Sort();

            // Assert
            IsOrdered(array);
        }

        [TestCase(new[] { 10, 5, 9, 77, 0, -8, 1, 10, 6 })]
        public void SortsArray(int[] array)
        {
            // Arrange
            var shellSort = new Shellsort(array);

            // Act
            shellSort.Sort();

            // Assert
            IsOrdered(array);
        }
    }
}