namespace SpecialCase.Tests.Unit.Player.CharacterTests
{
    using Moq;
    using NUnit.Framework;
    using SpecialCase.Player;

    [TestFixture]
    public class HealthReduceByDamage
    {
        [Test]
        public void ShouldReduceDamageOfDamageHitByFiftyPercentLessWithDiamondCloak()
        {
            // Arrange
            var diamondCloakMock = new Mock<DiamondCloak>().As<ISpecialDefence>();
            diamondCloakMock.Setup(m => m.CalculateDamage(It.IsAny<int>())).CallBase();
            var character = new Character(diamondCloakMock.Object);

            // Act
            var health = character.HealthReduceByDamage(10);

            // Assert
            Assert.AreEqual(95, health);
        }

        [Test]
        public void ShouldReduceDamageOfDamageHitByTwentyPercentLessWithIronCloak()
        {
            // Arrange
            var ironCloak = new Mock<IronCloak>().As<ISpecialDefence>();
            ironCloak.Setup(m => m.CalculateDamage(It.IsAny<int>())).CallBase();
            var character = new Character(ironCloak.Object);

            // Act
            var health = character.HealthReduceByDamage(10);

            // Assert
            Assert.AreEqual(92, health);
        }

        [Test]
        public void ShouldNotReduceDamageOfDamageHitWithNullCloak()
        {
            // Arrange
            var nullCloak = new Mock<NullCloak>().As<ISpecialDefence>();
            nullCloak.Setup(m => m.CalculateDamage(It.IsAny<int>())).CallBase();
            var character = new Character(nullCloak.Object);

            // Act
            var health = character.HealthReduceByDamage(10);

            // Assert
            Assert.AreEqual(90, health);
        }
    }
}