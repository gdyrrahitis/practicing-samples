namespace Patterns.Observer.Tests.PublisherTests
{
    using System.Collections.Generic;
    using Moq;
    using NUnit.Framework;

    [TestFixture]
    public class Unsubscribe
    {
        [Test]
        public void RemovesSubscriberSuccessfullyInPrePopulatedList()
        {
            // Arrange
            var subscriberMock = new Mock<ISubscriber>();
            var subscribers = new List<ISubscriber> { subscriberMock.Object };
            var publisher = new Publisher(subscribers);

            // Act
            publisher.UnSubscribe(subscriberMock.Object);

            // Assert
            Assert.AreEqual(0, publisher.Subscribers.Count);
        }

        [Test]
        public void DoesNotRemoveIfSubscriberIsNotInTheList()
        {
            // Arrange
            var subscriberMock = new Mock<ISubscriber>();
            var notInTheListSubscriberMock = new Mock<ISubscriber>();
            var subscribers = new List<ISubscriber> { subscriberMock.Object };
            var publisher = new Publisher(subscribers);

            // Act
            publisher.UnSubscribe(notInTheListSubscriberMock.Object);

            // Assert
            Assert.AreEqual(1, publisher.Subscribers.Count);
        }

        [Test]
        public void DoesNotRemoveIfSubscriberIsNull()
        {
            // Arrange
            var subscriberMock = new Mock<ISubscriber>();
            var subscribers = new List<ISubscriber> { subscriberMock.Object };
            var publisher = new Publisher(subscribers);

            // Act
            publisher.UnSubscribe(null);

            // Assert
            Assert.AreEqual(1, publisher.Subscribers.Count);
        }
    }
}