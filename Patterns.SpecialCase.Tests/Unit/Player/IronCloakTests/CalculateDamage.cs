namespace Patterns.SpecialCase.Tests.Unit.Player.IronCloakTests
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
        public void ShouldReturnTwentyPercentOfInput(int damage)
        {
            // Assert
            var ironCloak = new IronCloak();

            // Act
            var result = ironCloak.CalculateDamage(damage);

            // Assert
            Assert.AreEqual(GetTwentyPercent(damage), result);
        }

        private int GetTwentyPercent(int damage)
        {
            return (int) (damage * 0.2);
        }
    }
}