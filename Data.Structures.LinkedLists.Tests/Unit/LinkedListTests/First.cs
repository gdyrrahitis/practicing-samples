namespace Data.Structures.LinkedLists.Tests.Unit.LinkedListTests
{
    using NUnit.Framework;

    [TestFixture]
    public class First
    {
        [Test]
        public void IsNull()
        {
            // Arrange
            var list = new LinkedList();

            // Act
            var result = list.First;

            // Assert
            Assert.AreEqual(null, result);
        }
    }
}