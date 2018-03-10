namespace Patterns.Builder.Tests.Cyborgs.FriendlyCyborgTests
{
    using Builder.Cyborgs;
    using Xunit;

    public class Talk
    {
        [Fact]
        public void SaysComeWithMeIfYouWantToLive()
        {
            // Arrange
            var terminator = new FriendlyCyborg();

            // Act
            var said = terminator.Talk();

            // Assert
            Assert.Equal("Come with me if you want to live", said);
        }
    }
}