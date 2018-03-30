namespace Data.Structures.Queue.Tests.QueueTests
{
    using System;
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

    [TestFixture]
    public class Pop
    {
        [Test]
        public void SuccessfullyOneItem()
        {
            // Arrange
            var queue = new Queue();
            queue.Push(10);

            // Act
            var result = queue.Pop();

            // Assert
            AreEqual(10, result);
        }

        [Test]
        public void SuccessfullyTwoItems()
        {
            // Arrange
            var queue = new Queue();
            queue.Push(10);
            queue.Push(55);

            // Act
            var ten = queue.Pop();
            var fiftyFive = queue.Pop();

            // Assert
            AreEqual(10, ten);
            AreEqual(55, fiftyFive);
        }

        [Test]
        public void ThrowsExceptionWhenTryingToPopEmptyQueue()
        {
            // Arrange
            var queue = new Queue();
            queue.Push(25);

            // Act
            var result = queue.Pop();
            var exception = Throws<Exception>(() => queue.Pop());

            // Assert
            AreEqual(25, result);
            AreEqual("Queue is empty", exception.Message);
        }
    }
}