namespace Patterns.Builder.Tests.Cyborgs.ArmsTests
{
    using Builder.Cyborgs;
    using Xunit;

    public class Power
    {
        [Fact]
        public void ArmsPowerIsOneHundredAndFifty()
        {
            // Arrange
            var arms = new Arms();

            // Act
            var power = arms.Power();

            // Assert
            Assert.Equal(150, power);
        }
    }
}