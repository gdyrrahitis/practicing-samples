namespace Stack.Tests.Unit.StackTests
{
    using System;
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

    [TestFixture]
    public class Peek
    {
        [Test]
        public void CustomStack_PeekBeforePush_ThrowsErrorEmptyStack_Test()
        {
            // Arrange
            var stack = new Stack();

            // Act | Assert
            Throws<Exception>(() => stack.Peek(), "Empty stack");
        }
    }
}