namespace Patterns.Decorator.Tests.WeaponDecoratorTests
{
    using Moq;
    using NUnit.Framework;

    [TestFixture]
    public class Accuracy
    {
        private Mock<IWeapon> _mockedWeapon;

        [SetUp]
        public void Setup()
        {
            _mockedWeapon = new Mock<IWeapon>();
            _mockedWeapon.Setup(weapon => weapon.Accuracy).Returns(99);
        }

        [Test]
        public void IsNintyNine()
        {
            // Arrange
            var decorator = new WeaponDecorator(_mockedWeapon.Object);

            // Act
            var result = decorator.Accuracy;

            // Assert
            Assert.That(result, Is.EqualTo(99));
        }
    }
}