namespace Patterns.Decorator.Tests.RifleTests
{
    using NUnit.Framework;

    [TestFixture]
    public class Recoil
    {
        [Test]
        public void IsFourtyEight()
        {
            // Arrange
            var rifle = new Rifle();

            // Act
            var result = rifle.Recoil;

            // Assert
            Assert.That(result, Is.EqualTo(48));
        }
    }
}