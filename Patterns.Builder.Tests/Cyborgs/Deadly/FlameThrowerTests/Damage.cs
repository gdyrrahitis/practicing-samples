namespace Patterns.Builder.Tests.Cyborgs.Deadly.FlameThrowerTests
{
    using Builder.Cyborgs.Deadly;
    using Xunit;

    public class Damage
    {
        [Fact]
        public void CausedIsThreeHundred()
        {
            // Arrange
            var weapon = new FlameThrower();

            // Act
            var damage = weapon.Damage();

            // Assert
            Assert.Equal(300, damage);
        }
    }
}