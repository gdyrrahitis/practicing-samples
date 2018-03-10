namespace Patterns.Builder.Tests.Cyborgs.Deadly.TerminatorCyborgTests
{
    using Builder.Cyborgs.Deadly;
    using Xunit;

    public class Mission
    {
        [Fact]
        public void ItsMissionIsToKill()
        {
            // Arrange
            var terminator = new TerminatorCyborg();

            // Act
            var mission = terminator.Mission();

            // Assert
            Assert.Equal("Kill", mission);
        }
    }
}