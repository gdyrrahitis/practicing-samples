namespace Decorator.Tests.ScopeDecoratorTests
{
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

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
            That(initialAccuracy, Is.EqualTo(65));
            That(result, Is.EqualTo(90));
            That(decorator.Damage, Is.EqualTo(rifle.Damage));
            That(decorator.Recoil, Is.EqualTo(rifle.Recoil));
        }
    }
}