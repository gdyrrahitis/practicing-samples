namespace Patterns.Decorator.Tests.RifleTests
{
    using NUnit.Framework;

    [TestFixture]
    public class Accuracy
    {
        [Test]
        public void IsSixtyFive()
        {
            // Arrange
            var rifle = new Rifle();

            // Act
            var result = rifle.Accuracy;

            // Assert
            Assert.That(result, Is.EqualTo(65));
        }
    }
}