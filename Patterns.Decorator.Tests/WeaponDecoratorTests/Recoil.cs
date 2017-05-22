namespace Patterns.Decorator.Tests.WeaponDecoratorTests
{
    using Moq;
    using NUnit.Framework;

    [TestFixture]
    public class Recoil
    {
        private Mock<IWeapon> _mockedWeapon;

        [SetUp]
        public void Setup()
        {
            _mockedWeapon = new Mock<IWeapon>();
            _mockedWeapon.Setup(weapon => weapon.Recoil).Returns(77);
        }

        [Test]
        public void IsSeventySeven()
        {
            // Arrange
            var decorator = new WeaponDecorator(_mockedWeapon.Object);

            // Act
            var result = decorator.Recoil;
            
            // Assert
            Assert.That(result, Is.EqualTo(77));
        }
    }
}