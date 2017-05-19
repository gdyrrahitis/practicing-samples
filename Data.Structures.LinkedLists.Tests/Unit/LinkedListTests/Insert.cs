namespace LinkedLists.Tests.Unit.LinkedListTests
{
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

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
            IsNull(result.First);
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
            AreEqual(value, iterator.Current.Value);
        }

        [Test]
        public void NewLinkItemIsInsertedOnFirstNodeMovingTheOtherToSecond()
        {
            // Arrange | Act
            _list.Insert(15);
            _list.Insert(20);

            // Assert
            AreEqual(20, _list.First.Value);
            IsNotNull(_list.First.Next);
            AreEqual(15, _list.First.Next.Value);
        }

        [Test]
        public void NewLinkItemIsInsertedOnFirstNodeMovingTheOtherToSecondAndThird()
        {
            // Arrange | Act
            _list.Insert(15);
            _list.Insert(20);
            _list.Insert(6);

            // Assert
            AreEqual(6, _list.First.Value);
            AreEqual(20, _list.First.Next.Value);
            AreEqual(15, _list.First.Next.Next.Value);
        }
    }
}