namespace Bubblesort.Tests.Unit.BubblesortTests.V2
{
    using Bubblesort.V2;
    using NUnit.Framework;

    [TestFixture]
    public class BubbleSortTests
    {
        [Test]
        public void Bubblesort_Tests()
        {
            // Arrange
            var sort = new Bubblesort();

            // Act | Assert
            Assert.IsInstanceOf<Bubblesort>(sort);
            Assert.AreEqual(new[] { 1 }, sort.Sort(new[] { 1 }));
            Assert.AreEqual(new[] { 1, 2 }, sort.Sort(new[] { 1, 2 }));
            Assert.AreEqual(new[] { 1, 1, 1, 2 }, sort.Sort(new[] { 1, 2, 1, 1 }));
            Assert.AreEqual(new[] { 1, 1, 1, 2, 19 }, sort.Sort(new[] { 1, 2, 1, 1, 19 }));
            Assert.AreEqual(new[] { 1, 1, 1, 2, 8, 19 }, sort.Sort(new[] { 1, 2, 1, 1, 19, 8 }));
        }

        [Test]
        public void Bubblesort_Descenting_Tests()
        {
            // Arrange
            var sort = new Bubblesort();

            // Act | Assert
            Assert.IsInstanceOf<Bubblesort>(sort);
            Assert.AreEqual(new[] { 1 }, sort.Sort(new[] { 1 }, Sort.Descenting));
            Assert.AreEqual(new[] { 2, 1}, sort.Sort(new[] { 1, 2 }, Sort.Descenting));
            Assert.AreEqual(new[] {  2, 1, 1, 1 }, sort.Sort(new[] { 1, 2, 1, 1 }, Sort.Descenting));
            Assert.AreEqual(new[] { 19, 2, 1, 1, 1 }, sort.Sort(new[] { 1, 2, 1, 1, 19 }, Sort.Descenting));
            Assert.AreEqual(new[] { 19, 8, 2, 1, 1, 1 }, sort.Sort(new[] { 1, 2, 1, 1, 19, 8 }, Sort.Descenting));
        }
    }
}
