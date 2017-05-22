namespace Data.Structures.LinkedLists.Tests.Unit.LinkedListTests
{
    using NUnit.Framework;

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
            Assert.IsNotNull(iterator);
            Assert.AreEqual(false, iterator.MoveNext());
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
            Assert.IsNotNull(iterator);
            Assert.AreEqual(true, iterator.MoveNext());
            Assert.AreEqual(10, iterator.Current.Value);
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
            Assert.IsNotNull(iterator);
            Assert.AreEqual(true, iterator.MoveNext());
            Assert.AreEqual(20, iterator.Current.Value);
            Assert.AreEqual(true, iterator.MoveNext());
            Assert.AreEqual(10, iterator.Current.Value);
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
            Assert.IsNotNull(iterator);
            Assert.AreEqual(true, iterator.MoveNext());
            Assert.AreEqual(10, iterator.Current.Value);
            Assert.AreEqual(false, iterator.MoveNext());
            Assert.IsNull(iterator.Current);
        }
    }
}