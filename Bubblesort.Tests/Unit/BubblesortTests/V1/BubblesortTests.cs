namespace Bubblesort.Tests.Unit.BubblesortTests.V1
{
    using System;
    using Bubblesort.V1;
    using NUnit.Framework;

    [TestFixture]
    public class BubblesortTests
    {
        [Test]
        public void InstanceIsDefined()
        {
            // Arrange
            var instance = new Bubblesort();

            // Act | Assert
            Assert.IsInstanceOf<Bubblesort>(instance);
        }

        [Test]
        public void ShouldThrowArgumentNullExceptionIfNullIsPassed()
        {
            // Arrange
            var bubblesort = new Bubblesort();

            // Act | Assert
            Assert.Throws<ArgumentNullException>(() => bubblesort.Sort(null));
        }

        [Test]
        public void ShouldSortAnArrayInAscentingOrder()
        {
            // Arrange
            var bubblesort = new Bubblesort();

            // Act | Assert
            Assert.AreEqual(new[] { 1 }, bubblesort.Sort(new[] { 1 }));
            Assert.AreEqual(new[] { 1, 2, 2, 3 }, bubblesort.Sort(new[] { 1, 2, 3, 2 }));
            Assert.AreEqual(new[] { 1, 1, 2, 2, 3, 3 }, bubblesort.Sort(new[] { 1, 2, 3, 2, 3, 1 }));
            Assert.AreEqual(new[] { 1, 1, 2, 2, 3, 3, 85 }, bubblesort.Sort(new[] { 1, 2, 3, 2, 3, 1, 85 }));
            Assert.AreEqual(new[] { 1, 1, 2, 2, 3, 3, 8, 15, 22, 85 }, bubblesort.Sort(new[] { 1, 2, 3, 2, 3, 1, 85, 22, 15, 8 }));
            Assert.AreEqual(new[] { 1, 1, 2, 2, 3, 3, 8, 15, 22, 24, 85 }, bubblesort.Sort(new[] { 1, 2, 3, 2, 3, 1, 85, 22, 15, 8, 24 }));
        }

        [Test]
        public void ShouldSortAnArrayInDescentingOrder()
        {
            // Arrange
            var bubblesort = new Bubblesort();

            // Act | Assert
            Assert.AreEqual(new[] { 1 }, bubblesort.Sort(new[] { 1 }, Order.Desc));
            Assert.AreEqual(new[] { 2, 1 }, bubblesort.Sort(new[] { 1, 2 }, Order.Desc));
            Assert.AreEqual(new[] { 2, 1, 1 }, bubblesort.Sort(new[] { 1, 2, 1 }, Order.Desc));
            Assert.AreEqual(new[] { 19, 12, 5, 4, 2, 1, 1 }, bubblesort.Sort(new[] { 1, 2, 1, 5, 19, 12, 4 }, Order.Desc));
        }
    }
}
