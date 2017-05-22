namespace Data.Structures.LinkedLists.Tests.Unit.IteratorTests
{
    using Moq;
    using NUnit.Framework;

    [TestFixture]
    public class Reset
    {
        private Mock<ILinkedList> _listMock;

        [SetUp]
        public void Setup()
        {
            _listMock = new Mock<ILinkedList>();
        }

        [Test]
        public void SetsToFirstWhichIsNull()
        {
            // Arrange
            IIterator iterator = new Iterator(_listMock.Object);
            iterator.MoveNext();

            // Act
            iterator.Reset();

            // Assert
            Assert.AreEqual(null, iterator.Current);
        }

        [Test]
        public void SetsToFirstWhichHasNewLinkValue()
        {
            // Arrange
            _listMock.Setup(p => p.First).Returns(new Link(10));
            IIterator iterator = new Iterator(_listMock.Object);
            iterator.MoveNext();

            // Act
            iterator.Reset();

            // Assert
            Assert.AreEqual(10, iterator.Current.Value);
        }

        [Test]
        public void SetsToFirstWhichHasNewLinkValueAfterInsertingTwoNewLinks()
        {
            // Arrange
            var link = new Link(10)
            {
                Next = new Link(20)
            };
            _listMock.Setup(p => p.First).Returns(link);
            IIterator iterator = new Iterator(_listMock.Object);
            MoveIteratorToSecondNode(iterator);

            // Act
            iterator.Reset();

            // Assert
            Assert.AreEqual(10, iterator.Current.Value);
        }

        private static void MoveIteratorToSecondNode(IIterator iterator)
        {
            iterator.MoveNext();
            iterator.MoveNext();
        }
    }
}