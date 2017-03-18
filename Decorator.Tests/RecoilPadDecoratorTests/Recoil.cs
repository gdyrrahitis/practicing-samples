namespace Decorator.Tests.RecoilPadDecoratorTests
{
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

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
            That(initialRecoilValue, Is.EqualTo(48));
            That(result, Is.EqualTo(71));
            That(decorator.Damage, Is.EqualTo(rifle.Damage));
            That(decorator.Accuracy, Is.EqualTo(rifle.Accuracy));
        }
    }
}