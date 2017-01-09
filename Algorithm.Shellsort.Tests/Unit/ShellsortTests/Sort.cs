namespace Algorithm.Shellsort.Tests.Unit.ShellsortTests
{
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

    [TestFixture]
    public class Sort
    {
        [Test]
        public void DoesNotSortSingleElementArray()
        {
            // Arrange
            var array = new[] { 1 };
            var shellSort = new Shellsort(array);

            // Act
            shellSort.Sort();

            // Assert
            AreEqual(new[] { 1 }, array);
        }

        [Test]
        public void SortsTwoElementsArray()
        {
            // Arrange
            var array = new[] { 10, 5 };
            var shellSort = new Shellsort(array);

            // Act
            shellSort.Sort();

            // Assert
            AreEqual(new[] { 5, 10 }, array);
        }

        [Test]
        public void SortsThreeElementsArray()
        {
            // Arrange
            var array = new[] { 10, 5, 6 };
            var shellSort = new Shellsort(array);

            // Act
            shellSort.Sort();

            // Assert
            AreEqual(new[] { 5, 6, 10 }, array);
        }

        [Test]
        public void SortsArray()
        {
            // Arrange
            var array = new[] { 10, 5, 9, 77, 0, -8, 1, 10, 6 };
            var shellSort = new Shellsort(array);

            // Act
            shellSort.Sort();

            // Assert
            AreEqual(new[] { -8, 0, 1, 5, 6, 9, 10, 10, 77 }, array);
        }
    }
}