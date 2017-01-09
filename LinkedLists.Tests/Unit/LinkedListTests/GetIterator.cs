namespace LinkedLists.Tests.Unit.LinkedListTests
{
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

    [TestFixture]
    public class GetIterator
    {
        [Test]
        public void CurrentEnumeratorIsNullAsNoElementAddedIntoList()
        {
            // Arrange
            var list = new LinkedList();

            // Act
            var iterator = list.GetIterator();

            // Assert
            IsNotNull(iterator);
            AreEqual(false, iterator.MoveNext());
        }

        [Test]
        public void IteratorIsMovedToFirstElement()
        {
            // Arrange
            var list = new LinkedList();
            list.Insert(10);

            // Act
            var iterator = list.GetIterator();

            // Assert
            IsNotNull(iterator);
            AreEqual(true, iterator.MoveNext());
            AreEqual(10, iterator.Current.Value);
        }

        [Test]
        public void IteratorIsMovedToSecondElement()
        {
            // Arrange
            var list = new LinkedList();
            list.Insert(10);
            list.Insert(20);

            // Act
            var iterator = list.GetIterator();

            // Assert
            IsNotNull(iterator);
            AreEqual(true, iterator.MoveNext());
            AreEqual(20, iterator.Current.Value);
            AreEqual(true, iterator.MoveNext());
            AreEqual(10, iterator.Current.Value);
        }

        [Test]
        public void IteratorIsMovedToToEnd()
        {
            // Arrange
            var list = new LinkedList();
            list.Insert(10);

            // Act
            var iterator = list.GetIterator();

            // Assert
            IsNotNull(iterator);
            AreEqual(true, iterator.MoveNext());
            AreEqual(10, iterator.Current.Value);
            AreEqual(false, iterator.MoveNext());
            IsNull(iterator.Current);
        }
    }
}