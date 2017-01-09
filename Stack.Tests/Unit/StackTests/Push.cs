namespace Stack.Tests.Unit.StackTests
{
    using System;
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

    [TestFixture]
    public class Push
    {
        [Test]
        public void CustomStack_PushItemsToStack_ThrowsExceptionWhenPushingBeyondStackLimits_Test()
        {
            // Arrange
            var stack = new Stack(3);

            // Act
            stack.Push(1);
            stack.Push(9);

            // Asserrt
            AreEqual(2, stack.Size);
            Throws<Exception>(() => stack.PushAndPeek(9), "Stack is full, cannot push.");
        }

        [Test]
        public void CustomStack_PushingFourItemsInStack_PeekTopItem_Test()
        {
            // Arrange
            var stack = new Stack(5);

            // Act
            stack.Push(8);
            stack.Push(15);
            stack.Push(7);
            stack.Push(789);

            // Assert
            AreEqual(4, stack.Size);
            AreEqual(789, stack.Peek());
        }
    }
}