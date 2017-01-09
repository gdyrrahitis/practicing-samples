namespace Observer.Tests.PublisherTests
{
    using System.Collections.Generic;
    using Moq;
    using NUnit.Framework;

    [TestFixture]
    public class Subscribe
    {
        [Test]
        public void NewSubscriberSuccessfullyWithoutPrePopulatingList()
        {
            // Arrange
            var subscriberMock = new Mock<ISubscriber>();
            var publisher = new Publisher();

            // Act
            publisher.Subscribe(subscriberMock.Object);

            // Assert
            Assert.AreEqual(1, publisher.Subscribers.Count);
        }

        [Test]
        public void NewSubscriberSuccessfullyIntoPrePopulatedList()
        {
            // Arrange
            var subscriberMock = new Mock<ISubscriber>();
            var subscribers = new List<ISubscriber> { new Mock<ISubscriber>().Object };
            var publisher = new Publisher(subscribers);

            // Act
            publisher.Subscribe(subscriberMock.Object);

            // Assert
            Assert.AreEqual(2, publisher.Subscribers.Count);
        }

        [Test]
        public void SubscriberWontBeAddedIfNull()
        {
            // Arrange
            var subscriberMock = new Mock<ISubscriber>();
            var subscribers = new List<ISubscriber> { subscriberMock.Object };
            var publisher = new Publisher(subscribers);

            // Act
            publisher.Subscribe(null);

            // Assert
            Assert.AreEqual(1, publisher.Subscribers.Count);
        }
    }
}