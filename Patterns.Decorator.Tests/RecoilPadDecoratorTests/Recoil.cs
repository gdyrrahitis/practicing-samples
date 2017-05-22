namespace Patterns.Decorator.Tests.RecoilPadDecoratorTests
{
    using NUnit.Framework;

    [TestFixture]
    public class Recoil
    {
        [Test]
        public void IsIncreasedToSeventyOneWhileTheOtherFeaturesRemainTheSame()
        {
            // Arrange
            var rifle = new Rifle();
            var initialRecoilValue = rifle.Recoil;
            var decorator = new RecoilPadDecorator(rifle);

            // Act
            var result = decorator.Recoil;

            // Assert
            Assert.That(initialRecoilValue, Is.EqualTo(48));
            Assert.That(result, Is.EqualTo(71));
            Assert.That(decorator.Damage, Is.EqualTo(rifle.Damage));
            Assert.That(decorator.Accuracy, Is.EqualTo(rifle.Accuracy));
        }
    }
}