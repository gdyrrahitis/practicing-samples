namespace Algorithm.SelectionSort.Tests.SelectionSortTests
{
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

    [TestFixture]
    public class Sort
    {
        [Test]
        public void SortsNothingAsArrayIsEmpty()
        {
            // Arrange
            var array = new[] { 0 };
            var selectionSort = new SelectionSort(array);

            // Act
            selectionSort.Sort();

            // Assert
            AreEqual(new[] { 0 }, array);
        }

        [Test]
        public void SortsArrayWithTwoElements()
        {
            // Arrange
            var array = new[] { 0, -8 };
            var selectionSort = new SelectionSort(array);

            // Act
            selectionSort.Sort();

            // Assert
            AreEqual(new[] { -8, 0 }, array);
        }

        [Test]
        public void SortsArrayWithThreeElements()
        {
            // Arrange
            var array = new[] { 0, -8, 5 };
            var selectionSort = new SelectionSort(array);

            // Act
            selectionSort.Sort();

            // Assert
            AreEqual(new[] { -8, 0, 5 }, array);
        }

        [Test]
        public void SortsArrayWithFourElements()
        {
            // Arrange
            var array = new[] { 0, -8, 5, 1 };
            var selectionSort = new SelectionSort(array);

            // Act
            selectionSort.Sort();

            // Assert
            AreEqual(new[] { -8, 0, 1, 5 }, array);
        }

        [Test]
        public void SortsArrayCase()
        {
            // Arrange
            var array = new[] { 77, 99, 44, 55, 22, 88, 11, 0, 66, 33 };
            var selectionSort = new SelectionSort(array);

            // Act
            selectionSort.Sort();

            // Assert
            AreEqual(new[] { 0, 11, 22, 33, 44, 55, 66, 77, 88, 99 }, array);
        }
    }
}