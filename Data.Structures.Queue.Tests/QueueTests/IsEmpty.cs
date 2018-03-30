namespace Data.Structures.Queue.Tests.QueueTests
{
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

    [TestFixture]
    public class IsEmpty
    {
        [Test]
        public void ShouldReturnTrueForEmptyQueue()
        {
            // Arrange
            var queue = new Queue(10);

            // Act
            var result = queue.IsEmpty;

            // Assert
            True(result);
        }

        [Test]
        public void ShouldReturnFalseForPopulatedQueue()
        {
            // Arrange
            var queue = new Queue();
            queue.Push(10);

            // Act
            var result = queue.IsEmpty;

            // Assert
            False(result);
        }
    }
}