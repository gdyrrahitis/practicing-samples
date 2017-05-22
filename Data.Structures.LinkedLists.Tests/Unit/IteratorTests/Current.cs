namespace Data.Structures.LinkedLists.Tests.Unit.IteratorTests
{
    using NUnit.Framework;

    [TestFixture]
    public class Current
    {
        [Test]
        public void IsNull()
        {
            // Arrange 
            var list = new LinkedList();
            var iterator = new Iterator(list);

            // Act
            var result = iterator.Current;

            // Assert
            Assert.IsNull(result);
        }
    }
}