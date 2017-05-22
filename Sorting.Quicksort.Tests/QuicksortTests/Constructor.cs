namespace Sorting.Quicksort.Tests.QuicksortTests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class Constructor
    {
        [Test]
        public void ThrowsArgumentNullExceptionIfArrayIsNull()
        {
            // ReSharper disable once ObjectCreationAsStatement
            Assert.Throws<ArgumentNullException>(() => new Quicksort(null));
        }
    }
}