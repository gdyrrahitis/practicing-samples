namespace Patterns.Decorator.Tests.BarrelDecoratorTests
{
    using NUnit.Framework;

    [TestFixture]
    public class Damage
    {
        [Test]
        public void IsIncreasedToEightyNineWhileTheOtherFeaturesRemainTheSame()
        {
            // Arrange
            var rifle = new Rifle();
            var initialDamageValue = rifle.Damage;
            var decorator = new BarrelDecorator(rifle);

            // Act
            var result = decorator.Damage;

            // Assert
            Assert.That(initialDamageValue, Is.EqualTo(70));
            Assert.That(result, Is.EqualTo(89));
            Assert.That(decorator.Recoil, Is.EqualTo(rifle.Recoil));
            Assert.That(decorator.Accuracy, Is.EqualTo(rifle.Accuracy));
        }
    }
}