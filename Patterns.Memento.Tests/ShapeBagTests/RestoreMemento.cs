namespace Patterns.Memento.Tests.ShapeBagTests
{
    using System.Linq;
    using NUnit.Framework;

    [TestFixture]
    public class RestoreMemento
    {
        [Test]
        public void RestoresEmptyStateAfterAddingTwoItems()
        {
            // Arrange
            var shapeBag = new ShapeBag();
            var memento = shapeBag.CreateMemento();
            shapeBag.AddShape("triangle", new Triangle());
            shapeBag.AddShape("rectangle", new Rectangle());

            // Act
            shapeBag.RestoreMemento(memento);
            var result = shapeBag.GetShapes();

            // Assert
            CollectionAssert.IsEmpty(result);
        }

        [Test]
        public void RestoresStateWithOneItemStateAfterOneExtraItem()
        {
            // Arrange
            var shapeBag = new ShapeBag();
            shapeBag.AddShape("triangle", new Triangle());
            var memento = shapeBag.CreateMemento();
            shapeBag.AddShape("rectangle", new Rectangle());

            // Act
            shapeBag.RestoreMemento(memento);
            var result = shapeBag.GetShapes();

            // Assert
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("triangle", result.First().Key);
            Assert.IsInstanceOf<Triangle>(result.First().Value);
        }
    }
}