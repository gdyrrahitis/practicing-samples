namespace Patterns.Observer.Tests.PublisherTests
{
    using System.Linq;
    using Moq;
    using NUnit.Framework;

    [TestFixture]
    public class Constructor
    {
        [Test]
        public void InstanceIsDefined()
        {
            // Arrange 
            var subscriberMock = new Mock<ISubscriber>();
            var list = Enumerable.Repeat(subscriberMock.Object, 10);

            // Act
            var result = new Publisher(list);

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void IsInstanceOfIPublisher()
        {
            // Arrange | Act
            var result = new Publisher();

            // Assert
            Assert.IsInstanceOf<IPublisher>(result);
        }
    }
}