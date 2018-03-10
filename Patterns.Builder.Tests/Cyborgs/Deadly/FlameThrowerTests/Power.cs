namespace Patterns.Builder.Tests.Cyborgs.Deadly.FlameThrowerTests
{
    using Builder.Cyborgs.Deadly;
    using Xunit;

    public class Power
    {
        [Fact]
        public void WeaponPowerIsFifty()
        {
            // Arrange
            var weapon = new FlameThrower();

            // Act
            var power = weapon.Power();

            // Assert
            Assert.Equal(50, power);
        }
    }
}