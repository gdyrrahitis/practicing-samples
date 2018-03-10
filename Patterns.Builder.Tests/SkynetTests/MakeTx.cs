namespace Patterns.Builder.Tests.SkynetTests
{
    using System.Linq;
    using Builder.Cyborgs;
    using Xunit;
    using static Xunit.Assert;

    public class MakeTx
    {
        [Fact]
        public void GetsBackTxModel()
        {
            // Arrange | Act
            var tx = Skynet.MakeTx();

            // Assert
            Equal("Kill", tx.Mission());
            Equal("Kill Sarah Conor", tx.Talk());
            Equal(75, tx.Legs.Power());
            Equal(200, tx.Head.Power());
            Equal(500, tx.Torso.Power());
            Equal(150, tx.Arms.Power());
            Single(tx.Extras);
            Equal(50, tx.Extras.First().Power());
            Equal(300, ((WeaponPart)tx.Extras.First()).Damage());
        }
    }
}