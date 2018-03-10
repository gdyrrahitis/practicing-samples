namespace Patterns.Builder.Tests.SkynetTests
{
    using Xunit;
    using static Xunit.Assert;

    public class MakeT800
    {
        [Fact]
        public void GetsBackT800Model()
        {
            // Arrange | Act
            var t800 = Skynet.MakeT800();

            // Assert
            Equal("Keep alive", t800.Mission());
            Equal("Come with me if you want to live", t800.Talk());
            Equal(75, t800.Legs.Power());
            Equal(200, t800.Head.Power());
            Equal(100, t800.Torso.Power());
            Equal(150, t800.Arms.Power());
            Empty(t800.Extras);
        }
    }
}