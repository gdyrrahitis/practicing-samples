namespace Patterns.Builder.Tests.Cyborgs.TorsoTests
{
    using Builder.Cyborgs;
    using Xunit;

    public class Power
    {
        [Fact]
        public void TorsoMaxPowerIsOneHundred()
        {
            // Arrange
            var torso = new Torso();

            // Act
            var power = torso.Power();

            // Assert
            Assert.Equal(100, power);
        }
    }
}