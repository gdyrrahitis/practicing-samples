namespace Data.Structures.LinkedLists.Tests.Unit.BiDirectionalLinkedListTests
{
    using NUnit.Framework;

    [TestFixture]
    public class Remove
    {
        private IBiDirectionalLinkedList _list;

        [SetUp]
        public void Setup()
        {
            _list = new BiDirectionalLinkedList();
        }

        [Test]
        public void RemovesNothingFromEmptyList()
        {
            // Arrange | Act
            _list.Remove();

            // Assert
            Assert.IsNull(_list.First);
            Assert.IsNull(_list.Last);
        }

        [Test]
        public void RemovesOnlyElementInList()
        {
            // Arrange
            _list.Append(20);

            // Act
            _list.Remove();

            // Assert
            Assert.IsNull(_list.First);
            Assert.IsNull(_list.Last);
        }

        [Test]
        public void RemovesFirstElementInList()
        {
            // Arrange
            _list.Append(16);
            _list.Append(20);

            // Act
            _list.Remove();

            // Assert
            Assert.AreEqual(20, _list.First.Value);
            Assert.AreEqual(20, _list.Last.Value);
        }
    }
}