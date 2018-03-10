namespace Patterns.Builder.Tests.Cyborgs.HeadTests
{
    using Builder.Cyborgs;
    using Xunit;

    public class Power
    {
        [Fact]
        public void HeadPowerIsTwoHundred()
        {
            // Arrange
            var head = new Head();

            // Act
            var power = head.Power();

            // Assert
            Assert.Equal(200, power);
        }
    }
}