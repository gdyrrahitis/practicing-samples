namespace Data.Structures.LinkedLists.Tests.Unit.LinkedListTests
{
    using NUnit.Framework;

    [TestFixture]
    public class Find
    {
        private ILinkedList _list;

        [SetUp]
        public void Setup()
        {
            _list = new LinkedList();
        }

        [Test]
        public void FindsNothingForEmptyList()
        {
            // Arrange | Act
            var result = _list.Find(10);

            // Assert
            Assert.IsNull(result);
        }

        [Test]
        public void FindsElementInOneNodeList()
        {
            // Arrange
            _list.Insert(10);

            // Act
            var result = _list.Find(10);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(10, result.Value);
        }

        [Test]
        public void FindsElementInTwoNodeList()
        {
            // Arrange
            _list.Insert(10);
            _list.Insert(23);

            // Act
            var result = _list.Find(10);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(10, result.Value);
        }

        [Test]
        public void FindsElementInThreeNodeList()
        {
            // Arrange
            _list.Insert(10);
            _list.Insert(23);
            _list.Insert(99);

            // Act
            var result = _list.Find(23);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(23, result.Value);
        }

        [Test]
        public void CannotFindElementReturnsNull()
        {
            // Arrange
            _list.Insert(10);
            _list.Insert(23);
            _list.Insert(99);

            // Act
            var result = _list.Find(6);

            // Assert
            Assert.IsNull(result);
        }
    }
}