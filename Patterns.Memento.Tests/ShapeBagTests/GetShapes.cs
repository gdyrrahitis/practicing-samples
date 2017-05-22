namespace Patterns.Memento.Tests.ShapeBagTests
{
    using System.Linq;
    using NUnit.Framework;

    [TestFixture]
    public class GetShapes
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
            shapeBag.AddShape("rectangle", new Rectangle());

            // Act
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
            shapeBag.AddShape("rectangle", new Rectangle());
            shapeBag.AddShape("triangle", new Triangle());

            // Act
            var shapes = shapeBag.GetShapes();

            // Assert
            Assert.AreEqual(2, shapes.Count);
            Assert.IsInstanceOf<Rectangle>(shapes["rectangle"]);
            Assert.IsInstanceOf<Triangle>(shapes["triangle"]);
        }
    }
}