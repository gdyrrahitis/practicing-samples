namespace Algorithm.Primes.Eratosthenes.Tests.Unit.V1.SieveTests
{
    using Eratosthenes.V1;
    using NUnit.Framework;

    [TestFixture]
    public class Calculate
    {
        [Test]
        public void InstanceIsDefined()
        {
            // Arrange
            var instance = new Sieve();

            // Act | Assert
            Assert.IsInstanceOf<Sieve>(instance);
        }

        [Test]
        public void ReturnsAllPrimeNumbersForCasesFormThreeToThirty()
        {
            // Arrange
            var algorithm = new Sieve();

            // Act | Assert
            Assert.AreEqual(new[] { 2, 3 }, algorithm.Calculate(3));
            Assert.AreEqual(new[] { 2, 3, 5 }, algorithm.Calculate(5));
            Assert.AreEqual(new[] { 2, 3, 5 }, algorithm.Calculate(6));
            Assert.AreEqual(new[] { 2, 3, 5, 7 }, algorithm.Calculate(7));
            Assert.AreEqual(new[] { 2, 3, 5, 7 }, algorithm.Calculate(8));
            Assert.AreEqual(new[] { 2, 3, 5, 7 }, algorithm.Calculate(9));
            Assert.AreEqual(new[] { 2, 3, 5, 7 }, algorithm.Calculate(10));
            Assert.AreEqual(new[] { 2, 3, 5, 7, 11 }, algorithm.Calculate(11));
            Assert.AreEqual(new[] { 2, 3, 5, 7, 11 }, algorithm.Calculate(12));
            Assert.AreEqual(new[] { 2, 3, 5, 7, 11, 13 }, algorithm.Calculate(13));
            Assert.AreEqual(new[] { 2, 3, 5, 7, 11, 13 }, algorithm.Calculate(14));
            Assert.AreEqual(new[] { 2, 3, 5, 7, 11, 13 }, algorithm.Calculate(15));
            Assert.AreEqual(new[] { 2, 3, 5, 7, 11, 13 }, algorithm.Calculate(16));
            Assert.AreEqual(new[] { 2, 3, 5, 7, 11, 13, 17 }, algorithm.Calculate(17));
            Assert.AreEqual(new[] { 2, 3, 5, 7, 11, 13, 17 }, algorithm.Calculate(18));
            Assert.AreEqual(new[] { 2, 3, 5, 7, 11, 13, 17, 19 }, algorithm.Calculate(19));
            Assert.AreEqual(new[] { 2, 3, 5, 7, 11, 13, 17, 19 }, algorithm.Calculate(20));
            Assert.AreEqual(new[] { 2, 3, 5, 7, 11, 13, 17, 19 }, algorithm.Calculate(21));
            Assert.AreEqual(new[] { 2, 3, 5, 7, 11, 13, 17, 19 }, algorithm.Calculate(22));
            Assert.AreEqual(new[] { 2, 3, 5, 7, 11, 13, 17, 19, 23 }, algorithm.Calculate(23));
            Assert.AreEqual(new[] { 2, 3, 5, 7, 11, 13, 17, 19, 23 }, algorithm.Calculate(24));
            Assert.AreEqual(new[] { 2, 3, 5, 7, 11, 13, 17, 19, 23 }, algorithm.Calculate(25));
            Assert.AreEqual(new[] { 2, 3, 5, 7, 11, 13, 17, 19, 23 }, algorithm.Calculate(26));
            Assert.AreEqual(new[] { 2, 3, 5, 7, 11, 13, 17, 19, 23 }, algorithm.Calculate(27));
            Assert.AreEqual(new[] { 2, 3, 5, 7, 11, 13, 17, 19, 23 }, algorithm.Calculate(28));
            Assert.AreEqual(new[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 }, algorithm.Calculate(29));
            Assert.AreEqual(new[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 }, algorithm.Calculate(30));
        }
    }
}
