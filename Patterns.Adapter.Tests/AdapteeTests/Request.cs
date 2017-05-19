namespace Adapter.Tests.AdapteeTests
{
    using NUnit.Framework;

    [TestFixture]
    public class Request
    {
        [Test]
        public void ReturnsDivisionOfPrecisionTwo()
        {
            // Arrange
            var adaptee = new Adaptee();

            // Act
            var result = adaptee.Request(5);

            // Assert
            Assert.AreEqual(1.6666666666666667d, result);
        }
    }
}