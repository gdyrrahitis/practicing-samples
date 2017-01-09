namespace Algorithm.Quicksort.Tests.QuicksortTests
{
    using System;
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

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
            IsInstanceOf<Quicksort>(_quickSort);
        }

        [Test]
        public void ThrowsArgumentNullExceptionIfArrayIsNull()
        {
            // ReSharper disable once ObjectCreationAsStatement
            Throws<ArgumentNullException>(() => new Quicksort(null));
        }
    }
}