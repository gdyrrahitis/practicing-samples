namespace Stack.Tests.Unit.StackTests
{
    using System;
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

    [TestFixture]
    public class PeekAndSeek
    {

        [Test]
        public void CustomStack_PushAndPeekItemsToStack_ThrowsExceptionWhenPushingBeyondStackLimits_Test()
        {
            // Arrange
            var stack = new Stack(3);

            // Act | Assert
            AreEqual(1, stack.PushAndPeek(1));
            AreEqual(1, stack.Size);
            AreEqual(5, stack.PushAndPeek(5));
            AreEqual(2, stack.Size);
            Throws<Exception>(() => stack.PushAndPeek(9), "Stack is full, cannot push.");
        }
    }
}