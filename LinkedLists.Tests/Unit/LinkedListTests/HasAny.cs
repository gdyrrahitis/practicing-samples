namespace LinkedLists.Tests.Unit.LinkedListTests
{
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

    [TestFixture]
    public class HasAny
    {
        [Test]
        public void ListIsEmptyAtFirst()
        {
            // Arrange
            var list = new LinkedList();

            // Act
            var result = list.HasAny();

            // Assert
            AreEqual(false, result);
        }

        [Test]
        public void ListIsNotEmptyAfterInsert()
        {
            // Arrange
            var list = new LinkedList();
            list.Insert(10);

            // Act
            var result = list.HasAny();

            // Assert
            AreEqual(true, result);
        }
    }
}