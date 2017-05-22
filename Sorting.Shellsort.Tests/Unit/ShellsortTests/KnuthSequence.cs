namespace Sorting.Shellsort.Tests.Unit.ShellsortTests
{
    using NUnit.Framework;

    [TestFixture]
    public class KnuthSequence
    {
        private Shellsort _shellSort;

        [SetUp]
        public void Setup()
        {
            _shellSort = new Shellsort(new int[0]);
        }

        [TestCase(1, 4)]
        [TestCase(4, 13)]
        [TestCase(13, 40)]
        [TestCase(40, 121)]
        [TestCase(121, 364)]
        [TestCase(364, 1093)]
        [TestCase(1093, 3280)]
        public void CalculatesCorrectly(int h, int expected)
        {
            // Act
            var result = _shellSort.KnuthSequence(h);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}