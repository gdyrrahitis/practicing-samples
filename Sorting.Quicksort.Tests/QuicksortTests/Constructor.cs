namespace Sorting.Quicksort.Tests.QuicksortTests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class Constructor
    {
        private Quicksort _quickSort;

        [SetUp]
        public void Setup()
        {
            _quickSort = new Quicksort(new int[0]);
        }

        [Test]
        public void InstanceIsDefined()
        {
            Assert.IsInstanceOf<Quicksort>(_quickSort);
        }

        [Test]
        public void ThrowsArgumentNullExceptionIfArrayIsNull()
        {
            // ReSharper disable once ObjectCreationAsStatement
            Throws<ArgumentNullException>(() => new Quicksort(null));
        }
    }
}