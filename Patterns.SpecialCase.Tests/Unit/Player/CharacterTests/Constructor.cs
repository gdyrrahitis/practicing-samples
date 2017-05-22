namespace Patterns.SpecialCase.Tests.Unit.Player.CharacterTests
{
    using Moq;
    using NUnit.Framework;
    using SpecialCase.Player;

    [TestFixture]
    public class Constructor
    {
        private Character _character;

        [SetUp]
        public void Setup()
        {
            var specialDefenceMock = new Mock<ISpecialDefence>();
            _character = new Character(specialDefenceMock.Object);
        }

        [Test]
        public void InstanceIsDefined()
        {
            // Assert
            Assert.IsNotNull(_character);
        }
    }
}