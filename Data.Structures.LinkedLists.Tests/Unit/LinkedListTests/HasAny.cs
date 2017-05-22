namespace Data.Structures.LinkedLists.Tests.Unit.LinkedListTests
{
    using NUnit.Framework;

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
            Assert.AreEqual(false, result);
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
            Assert.AreEqual(true, result);
        }
    }
}