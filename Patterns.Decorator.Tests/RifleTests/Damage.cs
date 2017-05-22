namespace Patterns.Decorator.Tests.RifleTests
{
    using NUnit.Framework;

    [TestFixture]
    public class Damage
    {
        [Test]
        public void IsSeventy()
        {
            // Arrange
            var rifle = new Rifle();

            // Act
            var result = rifle.Damage;

            // Assert
            Assert.That(result, Is.EqualTo(70));
        }
    }
}