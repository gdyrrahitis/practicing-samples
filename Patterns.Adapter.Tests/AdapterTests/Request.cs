namespace Patterns.Adapter.Tests.AdapterTests
{
    using NUnit.Framework;

    [TestFixture]
    public class Request
    {
        [Test]
        public void ReturnsInteger()
        {
            // Arrage
            var target = new Adapter();

            // Act
            var result = target.Request(5);

            // Assert
            Assert.AreEqual(1, result);
        }
    }
}