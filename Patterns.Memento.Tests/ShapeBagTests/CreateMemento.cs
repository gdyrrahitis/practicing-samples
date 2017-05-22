namespace Patterns.Memento.Tests.ShapeBagTests
{
    using System.Linq;
    using NUnit.Framework;

    [TestFixture]
    public class CreateMemento
    {
        [Test]
        public void CreatesEmptyStateMemento()
        {
            // Arrange
            var shapeBag = new ShapeBag();

            // Act
            var result = shapeBag.CreateMemento();

            // Assert
            CollectionAssert.IsEmpty(result.State);
        }

        [Test]
        public void CreatesMementoWithOneItem()
        {
            // Arrange
            var shapeBag = new ShapeBag();
            shapeBag.AddShape("triangle", new Triangle());

            // Act
            var memento = shapeBag.CreateMemento();

            // Assert
            Assert.AreEqual(1, memento.State.Count);
            Assert.AreEqual("triangle", memento.State.First().Key);
            Assert.IsInstanceOf<Triangle>(memento.State.First().Value);
        }
    }
}