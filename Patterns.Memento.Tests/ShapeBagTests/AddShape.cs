namespace Patterns.Memento.Tests.ShapeBagTests
{
    using System.Linq;
    using NUnit.Framework;

    [TestFixture]
    public class AddShape
    {
        [Test]
        public void ReturnsEmptyDictionary()
        {
            // Arrange
            var shapeBag = new ShapeBag();

            // Act
            var shapes = shapeBag.GetShapes();

            // Assert
            CollectionAssert.IsEmpty(shapes);
        }

        [Test]
        public void ReturnsOneItemAfterAddingExactlyOneShape()
        {
            // Arrange
            var shapeBag = new ShapeBag();

            // Act
            shapeBag.AddShape("rectangle", new Rectangle());
            var shapes = shapeBag.GetShapes();

            // Assert
            Assert.AreEqual(1, shapes.Count);
            Assert.AreEqual("rectangle", shapes.First().Key);
            Assert.IsInstanceOf<Rectangle>(shapes.First().Value);
        }

        [Test]
        public void ReturnsTwoItemsAfterAddingTwoShapes()
        {
            // Arrange
            var shapeBag = new ShapeBag();

            // Act
            shapeBag.AddShape("rectangle", new Rectangle());
            shapeBag.AddShape("triangle", new Triangle());
            var shapes = shapeBag.GetShapes();

            // Assert
            Assert.AreEqual(2, shapes.Count);
            Assert.IsInstanceOf<Rectangle>(shapes["rectangle"]);
            Assert.IsInstanceOf<Triangle>(shapes["triangle"]);
        }
    }
}