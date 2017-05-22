namespace Patterns.Observer.Tests.PublisherTests
{
    using System.Collections.Generic;
    using Moq;
    using NUnit.Framework;

    [TestFixture]
    public class Notify
    {
        [Test]
        public void SuccessfullyAllSubscribers()
        {
            // Arrange
            var firstSubscriberMock = new Mock<ISubscriber>();
            var secondSubscriberMock = new Mock<ISubscriber>();
            var subscribers = new List<ISubscriber> { firstSubscriberMock.Object, secondSubscriberMock.Object };
            var publisher = new Publisher(subscribers);

            // Act
            publisher.Notify();

            // Assert
            firstSubscriberMock.Verify(m => m.MessageChanged(It.IsAny<string>()), Times.Once());
            secondSubscriberMock.Verify(m => m.MessageChanged(It.IsAny<string>()), Times.Once());
        }

        [Test]
        public void ImplicitCallOfNotifyByChangingMessageProperty()
        {
            // Arrange
            const string helloWorld = "Hello World!";
            var firstSubscriberMock = new Mock<ISubscriber>();
            var secondSubscriberMock = new Mock<ISubscriber>();
            var subscribers = new List<ISubscriber> { firstSubscriberMock.Object, secondSubscriberMock.Object };
            var publisher = new Publisher(subscribers);

            // Act
            publisher.Message = helloWorld;

            // Assert
            firstSubscriberMock.Verify(m => m.MessageChanged(It.Is<string>(s => s == helloWorld)), Times.Once());
            secondSubscriberMock.Verify(m => m.MessageChanged(It.Is<string>(s => s == helloWorld)), Times.Once());
        }
    }
}