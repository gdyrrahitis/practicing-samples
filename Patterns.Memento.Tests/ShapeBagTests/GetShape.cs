namespace Patterns.Memento.Tests.ShapeBagTests
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;

    [TestFixture]
    public class GetShape
    {
        [Test]
        public void ThrowsKeyNotFoundExceptionWhenTryingToFindShapeInEmptyDictionary()
        {
            // Arrange
            var shapeBag = new ShapeBag();

            // Act | Assert
            Assert.Throws<KeyNotFoundException>(() => shapeBag.GetShape("triangle"));
        }

        [TestCase("triangle", typeof(Triangle))]
        [TestCase("rectangle", typeof(Rectangle))]
        public void GetsShapeByNameFromDictionary(string name, Type expected)
        {
            // Arrange
            var shapeBag = new ShapeBag();
            shapeBag.AddShape("triangle", new Triangle());
            shapeBag.AddShape("rectangle", new Rectangle());

            // Act
            var shape = shapeBag.GetShape(name);

            // Assert
            Assert.IsInstanceOf(expected, shape);
        }
    }
}