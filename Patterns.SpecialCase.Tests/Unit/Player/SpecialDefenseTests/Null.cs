namespace Patterns.SpecialCase.Tests.Unit.Player.SpecialDefenseTests
{
    using NUnit.Framework;
    using SpecialCase.Player;

    [TestFixture]
    public class Null
    {
        [Test]
        public void ShouldReturnNullCloakInstance()
        {
            // Arrange | Act
            var result = SpecialDefense.Null;

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void ShouldReturnZeroForCalculateDamage()
        {
            // Arrange
            var nullCloak = SpecialDefense.Null;

            // Act
            var result = nullCloak.CalculateDamage(10);

            // Assert
            Assert.AreEqual(0, result);
        }
    }
}