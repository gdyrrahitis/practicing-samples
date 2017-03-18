namespace Bubblesort.Tests.Unit.BubblesortTests.V1
{
    using System;
    using Bubblesort.V1;
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

    [TestFixture]
    public class BubblesortTests
    {
        [Test]
        public void InstanceIsDefined()
        {
            // Arrange
            var instance = new Bubblesort();

            // Act | Assert
            IsInstanceOf<Bubblesort>(instance);
        }

        [Test]
        public void ShouldThrowArgumentNullExceptionIfNullIsPassed()
        {
            // Arrange
            var bubblesort = new Bubblesort();

            // Act | Assert
            Throws<ArgumentNullException>(() => bubblesort.Sort(null));
        }

        [Test]
        public void ShouldSortAnArrayInAscentingOrder()
        {
            // Arrange
            var bubblesort = new Bubblesort();

            // Act | Assert
            AreEqual(new[] { 1 }, bubblesort.Sort(new[] { 1 }));
            AreEqual(new[] { 1, 2, 2, 3 }, bubblesort.Sort(new[] { 1, 2, 3, 2 }));
            AreEqual(new[] { 1, 1, 2, 2, 3, 3 }, bubblesort.Sort(new[] { 1, 2, 3, 2, 3, 1 }));
            AreEqual(new[] { 1, 1, 2, 2, 3, 3, 85 }, bubblesort.Sort(new[] { 1, 2, 3, 2, 3, 1, 85 }));
            AreEqual(new[] { 1, 1, 2, 2, 3, 3, 8, 15, 22, 85 }, bubblesort.Sort(new[] { 1, 2, 3, 2, 3, 1, 85, 22, 15, 8 }));
            AreEqual(new[] { 1, 1, 2, 2, 3, 3, 8, 15, 22, 24, 85 }, bubblesort.Sort(new[] { 1, 2, 3, 2, 3, 1, 85, 22, 15, 8, 24 }));
        }

        [Test]
        public void ShouldSortAnArrayInDescentingOrder()
        {
            // Arrange
            var bubblesort = new Bubblesort();

            // Act | Assert
            AreEqual(new[] { 1 }, bubblesort.Sort(new[] { 1 }, Order.Desc));
            AreEqual(new[] { 2, 1 }, bubblesort.Sort(new[] { 1, 2 }, Order.Desc));
            AreEqual(new[] { 2, 1, 1 }, bubblesort.Sort(new[] { 1, 2, 1 }, Order.Desc));
            AreEqual(new[] { 19, 12, 5, 4, 2, 1, 1 }, bubblesort.Sort(new[] { 1, 2, 1, 5, 19, 12, 4 }, Order.Desc));
        }
    }
}
