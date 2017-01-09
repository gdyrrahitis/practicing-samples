namespace LinkedLists.Tests.Unit.IteratorTests
{
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

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