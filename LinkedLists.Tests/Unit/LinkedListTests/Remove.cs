namespace LinkedLists.Tests.Unit.LinkedListTests
{
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

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
            AreEqual(false, _list.HasAny());
            IsNull(_list.First);
        }

        [Test]
        public void RemovesOnlyElementLeavingListEmpty()
        {
            // Arrange
            _list.Insert(10);

            // Act
            _list.Remove();

            // Assert
            AreEqual(false, _list.HasAny());
            IsNull(_list.First);
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
            AreEqual(true, _list.HasAny());
            AreEqual(10, _list.First.Value);
            IsNull(_list.First.Next);
        }
    }
}