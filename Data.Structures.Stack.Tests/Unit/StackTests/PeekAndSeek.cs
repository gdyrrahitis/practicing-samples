namespace Data.Structures.Stack.Tests.Unit.StackTests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class PeekAndSeek
    {

        [Test]
        public void CustomStack_PushAndPeekItemsToStack_ThrowsExceptionWhenPushingBeyondStackLimits_Test()
        {
            // Arrange
            var stack = new Stack(3);

            // Act | Assert
            Assert.AreEqual(1, stack.PushAndPeek(1));
            Assert.AreEqual(1, stack.Size);
            Assert.AreEqual(5, stack.PushAndPeek(5));
            Assert.AreEqual(2, stack.Size);
            Assert.Throws<Exception>(() => stack.PushAndPeek(9), "Stack is full, cannot push.");
        }
    }
}