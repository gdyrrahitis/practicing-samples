namespace Patterns.Builder.Tests.Cyborgs.LegsTests
{
    using Builder.Cyborgs;
    using Xunit;

    public class Power
    {
        [Fact]
        public void LegsPowerIsSeventyFive()
        {
            // Arrange
            var legs = new Legs();

            // Act
            var power = legs.Power();

            // Assert
            Assert.Equal(75, power);
        }
    }
}