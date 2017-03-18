namespace Bubblesort.Tests.Unit.BubblesortTests.V2
{
    using Bubblesort.V2;
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

    [TestFixture]
    public class BubbleSortTests
    {
        [Test]
        public void Bubblesort_Tests()
        {
            // Arrange
            var sort = new Bubblesort();

            // Act | Assert
            IsInstanceOf<Bubblesort>(sort);
            AreEqual(new[] { 1 }, sort.Sort(new[] { 1 }));
            AreEqual(new[] { 1, 2 }, sort.Sort(new[] { 1, 2 }));
            AreEqual(new[] { 1, 1, 1, 2 }, sort.Sort(new[] { 1, 2, 1, 1 }));
            AreEqual(new[] { 1, 1, 1, 2, 19 }, sort.Sort(new[] { 1, 2, 1, 1, 19 }));
            AreEqual(new[] { 1, 1, 1, 2, 8, 19 }, sort.Sort(new[] { 1, 2, 1, 1, 19, 8 }));
        }

        [Test]
        public void Bubblesort_Descenting_Tests()
        {
            // Arrange
            var sort = new Bubblesort();

            // Act | Assert
            IsInstanceOf<Bubblesort>(sort);
            AreEqual(new[] { 1 }, sort.Sort(new[] { 1 }, Sort.Descenting));
            AreEqual(new[] { 2, 1}, sort.Sort(new[] { 1, 2 }, Sort.Descenting));
            AreEqual(new[] {  2, 1, 1, 1 }, sort.Sort(new[] { 1, 2, 1, 1 }, Sort.Descenting));
            AreEqual(new[] { 19, 2, 1, 1, 1 }, sort.Sort(new[] { 1, 2, 1, 1, 19 }, Sort.Descenting));
            AreEqual(new[] { 19, 8, 2, 1, 1, 1 }, sort.Sort(new[] { 1, 2, 1, 1, 19, 8 }, Sort.Descenting));
        }
    }
}
