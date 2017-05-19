namespace Stack.Tests.Unit.StackTests
{
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

    [TestFixture]
    public class Constructor
    {
        [Test]
        public void InstanceIsDefined()
        {
            // Arrange
            var stack = new Stack();

            // Act | Assert
            IsInstanceOf<Stack>(stack);
        }

        [Test]
        public void InitializeWithSizeAndGetsLength()
        {
            // Arrange
            var stack = new Stack(10);

            // Act | Assert
            AreEqual(10, stack.Length);
        }
    }
}