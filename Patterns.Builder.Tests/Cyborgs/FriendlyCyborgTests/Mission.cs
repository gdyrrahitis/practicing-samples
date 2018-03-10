namespace Patterns.Builder.Tests.Cyborgs.FriendlyCyborgTests
{
    using Builder.Cyborgs;
    using Xunit;

    public class Mission
    {
        [Fact]
        public void ItsMissionIsToKeepYouAlive()
        {
            // Arrange
            var terminator = new FriendlyCyborg();

            // Act
            var mission = terminator.Mission();

            // Assert
            Assert.Equal("Keep alive", mission);
        }
    }
}