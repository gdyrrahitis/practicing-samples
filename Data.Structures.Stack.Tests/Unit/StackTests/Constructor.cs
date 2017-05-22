namespace Data.Structures.Stack.Tests.Unit.StackTests
{
    using NUnit.Framework;

    [TestFixture]
    public class Constructor
    {
        [Test]
        public void InstanceIsDefined()
        {
            // Arrange
            var stack = new Stack();

            // Act | Assert
            Assert.IsInstanceOf<Stack>(stack);
        }

        [Test]
        public void InitializeWithSizeAndGetsLength()
        {
            // Arrange
            var stack = new Stack(10);

            // Act | Assert
            Assert.AreEqual(10, stack.Length);
        }
    }
}