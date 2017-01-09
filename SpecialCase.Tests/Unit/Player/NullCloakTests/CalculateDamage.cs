namespace SpecialCase.Tests.Unit.Player.NullCloakTests
{
    using NUnit.Framework;
    using SpecialCase.Player;

    [TestFixture]
    public class CalculateDamage
    {
        [Test]
        [TestCase(10)]
        [TestCase(15)]
        [TestCase(50)]
        [TestCase(500)]
        [TestCase(820)]
        [TestCase(1130)]
        public void ShouldReturnZero(int damage)
        {
            // Assert
            var nullCloak = new NullCloak();

            // Act
            var result = nullCloak.CalculateDamage(damage);

            // Assert
            Assert.AreEqual(0, result);
        }
    }
}