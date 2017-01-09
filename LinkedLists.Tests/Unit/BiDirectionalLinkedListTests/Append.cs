namespace LinkedLists.Tests.Unit.BiDirectionalLinkedListTests
{
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

    [TestFixture]
    public class Append
    {
        private IBiDirectionalLinkedList _list;

        [SetUp]
        public void Setup()
        {
            _list = new BiDirectionalLinkedList();
        }

        [Test]
        public void AppendInEmptyList()
        {
            // Arrange | Act
            _list.Append(20);

            // Assert
            AreEqual(20, _list.First.Value);
            AreEqual(20, _list.Last.Value);
        }

        [Test]
        public void AppendInOneNodeList()
        {
            // Arrange
            _list.Append(10);

            // Act
            _list.Append(20);
            var iterator = _list.GetIterator();

            // Assert
            AreEqual(10, _list.First.Value);
            AreEqual(20, _list.Last.Value);
            AreEqual(true, iterator.MoveNext());
            AreEqual(10, iterator.Current.Value);
            AreEqual(true, iterator.MoveNext());
            AreEqual(20, iterator.Current.Value);
            AreEqual(false, iterator.MoveNext());
            AreEqual(null, iterator.Current);
        }

        [Test]
        public void AppendInAlreadyAppendedListOfTwoNodes()
        {
            // Arrange
            _list.Append(10);
            _list.Append(16);

            // Act
            _list.Append(20);
            var iterator = _list.GetIterator();

            // Assert
            AreEqual(10, _list.First.Value);
            AreEqual(20, _list.Last.Value);
            AreEqual(true, iterator.MoveNext());
            AreEqual(10, iterator.Current.Value);
            AreEqual(true, iterator.MoveNext());
            AreEqual(16, iterator.Current.Value);
            AreEqual(true, iterator.MoveNext());
            AreEqual(20, iterator.Current.Value);
            AreEqual(false, iterator.MoveNext());
            AreEqual(null, iterator.Current);
        }
    }
}