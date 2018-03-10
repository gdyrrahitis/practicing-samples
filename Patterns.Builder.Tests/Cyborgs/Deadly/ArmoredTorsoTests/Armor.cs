namespace Patterns.Builder.Tests.Cyborgs.Deadly.ArmoredTorsoTests
{
    using Builder.Cyborgs.Deadly;
    using Xunit;

    public class Armor
    {
        [Fact]
        public void ArmorIsFive()
        {
            // Arrange
            var torso = new ArmoredTorso();

            // Act
            var armor = torso.Armor();

            // Assert
            Assert.Equal(5, armor);
        }
    }
}