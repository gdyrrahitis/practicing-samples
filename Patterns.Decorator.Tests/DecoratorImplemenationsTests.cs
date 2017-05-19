namespace Decorator.Tests
{
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

    [TestFixture]
    public class DecoratorImplemenationsTests
    {
        [Test]
        public void WithoutDecoratorIsBaseRifle()
        {
            // Arrange
            var rifle = new Rifle();

            // Act
            var damage = rifle.Damage;
            var recoil = rifle.Recoil;
            var accuracy = rifle.Accuracy;

            // Assert
            That(damage, Is.EqualTo(70));
            That(accuracy, Is.EqualTo(65));
            That(recoil, Is.EqualTo(48));
        }

        [Test]
        public void WithRecoilPadIncreasesRecoilToSeventyOne()
        {
            // Arrange
            var baseRifle = new Rifle();
            var rifle = new RecoilPadDecorator(baseRifle);

            // Act
            var damage = rifle.Damage;
            var recoil = rifle.Recoil;
            var accuracy = rifle.Accuracy;

            // Assert
            That(damage, Is.EqualTo(70));
            That(accuracy, Is.EqualTo(65));
            That(recoil, Is.EqualTo(71));
        }

        [Test]
        public void AddedScopeInAccessoriesIncreasingAccuracyToNinty()
        {
            // Arrange
            var baseRifle = new Rifle();
            var withRecoilPad = new RecoilPadDecorator(baseRifle);
            var rifle = new ScopeDecorator(withRecoilPad);

            // Act
            var damage = rifle.Damage;
            var recoil = rifle.Recoil;
            var accuracy = rifle.Accuracy;

            // Assert
            That(damage, Is.EqualTo(70));
            That(accuracy, Is.EqualTo(90));
            That(recoil, Is.EqualTo(71));
        }

        [Test]
        public void AddedBarrelInAccessoriesIncreasingDamageToEightyNine()
        {
            // Arrange
            var baseRifle = new Rifle();
            var withRecoilPad = new RecoilPadDecorator(baseRifle);
            var withScope = new ScopeDecorator(withRecoilPad);
            var rifle = new BarrelDecorator(withScope);

            // Act
            var damage = rifle.Damage;
            var recoil = rifle.Recoil;
            var accuracy = rifle.Accuracy;

            // Assert
            That(damage, Is.EqualTo(89));
            That(accuracy, Is.EqualTo(90));
            That(recoil, Is.EqualTo(71));
        }
    }
}