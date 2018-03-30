namespace Data.Structures.Queue.Tests.QueueTests
{
    using System;
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

    [TestFixture]
    public class Push
    {
        [Test]
        public void SuccessfullyOneItem()
        {
            // Arrange
            var queue = new Queue(10);

            // Act
            queue.Push(1);

            // Assert
            AreEqual(1, queue.Size);
        }

        [Test]
        public void SuccessfullyTwoItems()
        {
            // Arrange
            var queue = new Queue(10);

            // Act
            queue.Push(3);
            queue.Push(5);

            // Assert
            AreEqual(2, queue.Size);
        }

        [Test]
        public void ThrowsErrorWhenQueueIsFull()
        {
            // Arrange
            var queue = new Queue(2);

            // Act
            queue.Push(3);
            queue.Push(5);
            var exception = Throws<Exception>(() => queue.Push(9));

            // Assert
            AreEqual("Queue is full", exception.Message);
        }

        [Test]
        public void ThrowsErrorWhenQueueIsFullAndSizeIsTwo()
        {
            // Arrange
            var queue = new Queue(2);

            // Act
            queue.Push(3);
            queue.Push(5);
            var exception = Throws<Exception>(() => queue.Push(9));

            // Assert
            AreEqual("Queue is full", exception.Message);
            AreEqual(2, queue.Size);
        }
    }
}