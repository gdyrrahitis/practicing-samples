namespace Patterns.Decorator.Tests.ScopeDecoratorTests
{
    using NUnit.Framework;

    [TestFixture]
    public class Accuracy
    {
        [Test]
        public void IsIncreasedToNintyAndOtherFeaturesRemainTheSame()
        {
            // Arrange
            var rifle = new Rifle();
            var initialAccuracy = rifle.Accuracy;
            var decorator = new ScopeDecorator(rifle);

            // Act
            var result = decorator.Accuracy;

            // Assert
            Assert.That(initialAccuracy, Is.EqualTo(65));
            Assert.That(result, Is.EqualTo(90));
            Assert.That(decorator.Damage, Is.EqualTo(rifle.Damage));
            Assert.That(decorator.Recoil, Is.EqualTo(rifle.Recoil));
        }
    }
}