namespace Patterns.Builder.Tests.Cyborgs.Deadly.TerminatorCyborgTests
{
    using Builder.Cyborgs.Deadly;
    using Xunit;

    public class Talk
    {
        [Fact]
        public void SaysItWantsToKillSarahConor()
        {
            // Arrange
            var terminator = new TerminatorCyborg();

            // Act
            var said = terminator.Talk();

            // Assert
            Assert.Equal("Kill Sarah Conor", said);
        }
    }
}