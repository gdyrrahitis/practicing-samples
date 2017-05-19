namespace Decorator.Tests.RifleTests
{
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

    [TestFixture]
    public class Accuracy
    {
        [Test]
        public void IsSixtyFive()
        {
            // Arrange
            var rifle = new Rifle();

            // Act
            var result = rifle.Accuracy;

            // Assert
            That(result, Is.EqualTo(65));
        }
    }
}