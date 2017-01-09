namespace LinkedLists.Tests.Unit.IteratorTests
{
    using Moq;
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

    [TestFixture]
    public class MoveNext
    {
        private Mock<ILinkedList> _listMock;

        [SetUp]
        public void Setup()
        {
            _listMock = new Mock<ILinkedList>();
        }

        [Test]
        public void MovesToNullAsThereAreNoElementsInList()
        {
            // Arrange
            var iterator = new Iterator(_listMock.Object);

            // Act
            var result = iterator.MoveNext();

            // Assert
            IsFalse(result);
            AreEqual(null, iterator.Current);
        }

        [Test]
        public void MovesToFirstElement()
        {
            // Arrange
            _listMock.Setup(p => p.First).Returns(new Link(10));
            var iterator = new Iterator(_listMock.Object);

            // Act
            var result = iterator.MoveNext();

            // Assert
            AreEqual(10, iterator.Current.Value);
            AreEqual(true, result);
        }

        [Test]
        public void MovesToSecondElement()
        {
            // Arrange
            var link = new Link(10)
            {
                Next = new Link(20)
            };
            _listMock.Setup(p => p.First).Returns(link);
            var iterator = new Iterator(_listMock.Object);

            // Act
            iterator.MoveNext();
            var result = iterator.MoveNext();

            // Assert
            AreEqual(true, result);
            IsNotNull(iterator.Current);
            AreEqual(20, iterator.Current.Value);
        }

        [Test]
        public void MovesToEnd()
        {
            // Arrange
            var link = new Link(10)
            {
                Next = new Link(20)
            };
            _listMock.Setup(p => p.First).Returns(link);
            var iterator = new Iterator(_listMock.Object);

            // Act
            iterator.MoveNext();
            iterator.MoveNext();
            var result = iterator.MoveNext();

            // Assert
            AreEqual(false, result);
            IsNull(iterator.Current);
        }

        [Test]
        public void MovesBeyondEnd()
        {
            // Arrange
            var link = new Link(10)
            {
                Next = new Link(20)
            };
            _listMock.Setup(p => p.First).Returns(link);
            var iterator = new Iterator(_listMock.Object);

            // Act
            iterator.MoveNext();
            iterator.MoveNext();
            iterator.MoveNext();
            var result = iterator.MoveNext();

            // Assert
            IsNull(iterator.Current);
            AreEqual(false, result);
        }
    }
}