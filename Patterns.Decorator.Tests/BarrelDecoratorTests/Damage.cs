namespace Decorator.Tests.BarrelDecoratorTests
{
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

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
            That(initialDamageValue, Is.EqualTo(70));
            That(result, Is.EqualTo(89));
            That(decorator.Recoil, Is.EqualTo(rifle.Recoil));
            That(decorator.Accuracy, Is.EqualTo(rifle.Accuracy));
        }
    }
}