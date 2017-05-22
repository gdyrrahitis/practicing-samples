namespace Patterns.Memento.Tests.ShapeBagTests
{
    using NUnit.Framework;

    [TestFixture]
    public class RemoveShape
    {
        [Test]
        public void RemovesFromSingleItemDictionary()
        {
            // Arrange
            var shapeBag = new ShapeBag();
            shapeBag.AddShape("triangle", new Triangle());

            // Act
            shapeBag.RemoveShape("triangle");
            
            // Assert
            Assert.AreEqual(0, shapeBag.GetShapes().Count);
        }

        [Test]
        public void DoesNotRemoveShapeThatDoesNotExist()
        {
            // Arrange
            var shapeBag = new ShapeBag();
            shapeBag.AddShape("rectangle", new Rectangle());

            // Act
            shapeBag.RemoveShape("triangle");

            // Assert
            Assert.AreEqual(1, shapeBag.GetShapes().Count);
        }
    }
}