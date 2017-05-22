namespace Data.Structures.LinkedLists.Tests.Unit.LinkedListTests
{
    using NUnit.Framework;

    [TestFixture]
    public class Remove
    {
        private ILinkedList _list;

        [SetUp]
        public void Setup()
        {
            _list = new LinkedList();
        }

        [Test]
        public void RemovesNothingAsListIsEmpty()
        {
            // Arrange | Act
            _list.Remove();

            // Assert
            Assert.AreEqual(false, _list.HasAny());
            Assert.IsNull(_list.First);
        }

        [Test]
        public void RemovesOnlyElementLeavingListEmpty()
        {
            // Arrange
            _list.Insert(10);

            // Act
            _list.Remove();

            // Assert
            Assert.AreEqual(false, _list.HasAny());
            Assert.IsNull(_list.First);
        }

        [Test]
        public void RemovesFirstElementMakingTheSecondFirst()
        {
            // Arrange
            _list.Insert(10);
            _list.Insert(8);

            // Act
            _list.Remove();

            // Assert
            Assert.AreEqual(true, _list.HasAny());
            Assert.AreEqual(10, _list.First.Value);
            Assert.IsNull(_list.First.Next);
        }
    }
}