namespace Data.Structures.Queue.Tests.QueueTests
{
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

    [TestFixture]
    public class Size
    {
        [TestCase(new[] { 2 })]
        [TestCase(new[] { 2, 3, 7 })]
        [TestCase(new[] { 2, 3, 7, 5 })]
        [TestCase(new[] { 2, 3, 7, 5, 7, 9, 10 })]
        public void QueueSizeShouldEqualInputArray(int[] array)
        {
            // Arrange
            var queue = new Queue(array.Length + 1);
            foreach (var value in array)
            {
                queue.Push(value);
            }

            // Act
            var result = queue.Size;

            // Assert
            AreEqual(array.Length, result);
        }
    }
}