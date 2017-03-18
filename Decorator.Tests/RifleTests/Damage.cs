namespace Decorator.Tests.RifleTests
{
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

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
            That(result, Is.EqualTo(70));
        }
    }
}