namespace Data.Structures.Queue.Tests.QueueTests
{
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

    [TestFixture]
    public class Empty
    {
        [Test]
        public void ShouldMakePopulatedQueueEmpty()
        {
            // Arrange
            var queue = new Queue();
            queue.Push(150);

            // Act
            queue.Empty();

            // Assert
            True(queue.IsEmpty);
        }
    }
}