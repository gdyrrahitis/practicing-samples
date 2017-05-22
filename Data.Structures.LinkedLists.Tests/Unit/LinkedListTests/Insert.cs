namespace Data.Structures.LinkedLists.Tests.Unit.LinkedListTests
{
    using NUnit.Framework;

    [TestFixture]
    public class Insert
    {
        private ILinkedList _list;

        [SetUp]
        public void Setup()
        {
             _list = new LinkedList();
        }

        [Test]
        public void CurrentIsNullAsNoInsertHappened()
        {
            // Arrange | Act
            var result = new LinkedList();

            // Assert
            Assert.IsNull(result.First);
        }

        [Test]
        public void CurrentIsLinkItemInserted()
        {
            // Arrange | Act
            _list.Insert(10);

            // Assert
            CurrentNodeValueIs(10);
        }

        private void CurrentNodeValueIs(int value)
        {
            var iterator = _list.GetIterator();
            iterator.MoveNext();
            Assert.AreEqual(value, iterator.Current.Value);
        }

        [Test]
        public void NewLinkItemIsInsertedOnFirstNodeMovingTheOtherToSecond()
        {
            // Arrange | Act
            _list.Insert(15);
            _list.Insert(20);

            // Assert
            Assert.AreEqual(20, _list.First.Value);
            Assert.IsNotNull(_list.First.Next);
            Assert.AreEqual(15, _list.First.Next.Value);
        }

        [Test]
        public void NewLinkItemIsInsertedOnFirstNodeMovingTheOtherToSecondAndThird()
        {
            // Arrange | Act
            _list.Insert(15);
            _list.Insert(20);
            _list.Insert(6);

            // Assert
            Assert.AreEqual(6, _list.First.Value);
            Assert.AreEqual(20, _list.First.Next.Value);
            Assert.AreEqual(15, _list.First.Next.Next.Value);
        }
    }
}