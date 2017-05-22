namespace Data.Structures.LinkedLists.Tests.Unit.LinkTests
{
    using NUnit.Framework;

    [TestFixture]
    public class Constructor
    {
        [Test]
        public void InstanceIsDefinedWithConstructorTakingIntegerAsParameter()
        {
            // Arrange | Act
            var result = new Link(10);

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void HasLinkReferenceNullDefined()
        {
            // Arrange | Act
            var link = new Link(10);

            // Assert
            Assert.IsNull(link.Next);
        }

        [Test]
        public void CanSetNextReference()
        {
            // Arrange
            var link = new Link(10);

            // Act
            link.Next = new Link(15);

            // Assert
            Assert.IsNotNull(link.Next);
        }

        [Test]
        public void CanSetNullToNextReference()
        {
            // Arrange
            var link = new Link(10);

            // Act
            link.Next = null;

            // Assert
            Assert.IsNull(link.Next);
        }

        [Test]
        public void GetValuePassedToConstructor()
        {
            // Arrange
            const int value = 15;

            // Act
            var link = new Link(value);

            // Assert
            Assert.AreEqual(value, link.Value);
        }
    }
}