namespace Data.Structures.Stack.Tests.Unit.StackTests
{
    using NUnit.Framework;

    [TestFixture]
    public class Pop
    {
        [Test]
        public void CustomStack_PopItemFromStack_Test()
        {
            // Arrange
            var stack = new Stack(5);
            stack.Push(5);
            stack.Push(8);
            stack.Push(12);
            stack.Push(78);

            // Act
            var item = stack.Pop();

            // Assert
            Assert.AreEqual(78, item);
            Assert.AreEqual(3, stack.Size);
        }
    }
}