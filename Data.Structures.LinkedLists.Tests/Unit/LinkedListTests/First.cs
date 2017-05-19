namespace LinkedLists.Tests.Unit.LinkedListTests
{
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

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
            AreEqual(null, result);
        }
    }
}