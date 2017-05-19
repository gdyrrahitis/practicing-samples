namespace Bubblesort.Tests.Unit.BubblesortTests
{
    using NUnit.Framework;
    using static NUnit.Framework.CollectionAssert;

    [TestFixture]
    public class Sort
    {
        [TestCase(new[] {9, 1, 10})]
        [TestCase(new[] {-7, 5, 88, -9})]
        [TestCase(new[] {555, -5, 11, 0, 99, 77, 33, 22, 66, 11, 88, 99, 44, 22, 55, 66})]
        public void UnsortedArraySuccessfully(int[] array)
        {
            // Arrange
            var bubblesort = new Bubblesort(array);

            // Act
            bubblesort.Sort();

            // Assert
            IsOrdered(array);
        }
    }
}
