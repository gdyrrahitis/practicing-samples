namespace Decorator.Tests.RifleTests
{
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

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
            That(result, Is.EqualTo(48));
        }
    }
}