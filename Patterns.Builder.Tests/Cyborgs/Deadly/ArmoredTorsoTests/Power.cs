namespace Patterns.Builder.Tests.Cyborgs.Deadly.ArmoredTorsoTests
{
    using Builder.Cyborgs.Deadly;
    using Xunit;

    public class Power
    {
        [Fact]
        public void TorsoPowerIsFiveHundred()
        {
            // Arrange
            var torso = new ArmoredTorso();

            // Act
            var power = torso.Power();

            // Assert
            Assert.Equal(500, power);
        }
    }
}