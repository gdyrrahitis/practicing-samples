namespace SpecialCase.Tests.Unit.Player.DiamondCloakTests
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
        public void ShouldReturnFiftyPercentOfInput(int damage)
        {
            // Assert
            var diamondCloak = new DiamondCloak();

            // Act
            var result = diamondCloak.CalculateDamage(damage);

            // Assert
            Assert.AreEqual(GetHalfDamage(damage), result);
        }

        private int GetHalfDamage(int damage)
        {
            return damage / 2;
        }
    }
}