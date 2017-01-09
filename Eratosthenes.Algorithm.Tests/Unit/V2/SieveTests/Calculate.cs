namespace Eratosthenes.Algorithm.Tests.Unit.V2.SieveTests
{
    using Algorithm.V2;
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

    [TestFixture]
    public class Calculate
    {
        [Test]
        public void InstanceIsDefined()
        {
            // Arrange
            var algorithm = new Sieve();

            // Act | Assert
            IsInstanceOf(typeof(Sieve), algorithm);
        }

        [Test]
        public void ReturnsAllPrimeNumbersForCasesFormTwoToThirty()
        {
            // Arrange
            var algorithm = new Sieve();

            // Act | Assert
            AreEqual(new[] { 2 }, algorithm.Calculate(2));
            AreEqual(new[] { 2, 3 }, algorithm.Calculate(3));
            AreEqual(new[] { 2, 3 }, algorithm.Calculate(4));
            AreEqual(new[] { 2, 3, 5 }, algorithm.Calculate(5));
            AreEqual(new[] { 2, 3, 5 }, algorithm.Calculate(6));
            AreEqual(new[] { 2, 3, 5, 7 }, algorithm.Calculate(7));
            AreEqual(new[] { 2, 3, 5, 7 }, algorithm.Calculate(8));
            AreEqual(new[] { 2, 3, 5, 7 }, algorithm.Calculate(9));
            AreEqual(new[] { 2, 3, 5, 7 }, algorithm.Calculate(10));
            AreEqual(new[] { 2, 3, 5, 7, 11 }, algorithm.Calculate(11));
            AreEqual(new[] { 2, 3, 5, 7, 11 }, algorithm.Calculate(12));
            AreEqual(new[] { 2, 3, 5, 7, 11, 13 }, algorithm.Calculate(13));
            AreEqual(new[] { 2, 3, 5, 7, 11, 13 }, algorithm.Calculate(14));
            AreEqual(new[] { 2, 3, 5, 7, 11, 13 }, algorithm.Calculate(15));
            AreEqual(new[] { 2, 3, 5, 7, 11, 13 }, algorithm.Calculate(16));
            AreEqual(new[] { 2, 3, 5, 7, 11, 13, 17 }, algorithm.Calculate(17));
            AreEqual(new[] { 2, 3, 5, 7, 11, 13, 17 }, algorithm.Calculate(18));
            AreEqual(new[] { 2, 3, 5, 7, 11, 13, 17, 19 }, algorithm.Calculate(19));
            AreEqual(new[] { 2, 3, 5, 7, 11, 13, 17, 19 }, algorithm.Calculate(20));
            AreEqual(new[] { 2, 3, 5, 7, 11, 13, 17, 19 }, algorithm.Calculate(21));
            AreEqual(new[] { 2, 3, 5, 7, 11, 13, 17, 19 }, algorithm.Calculate(22));
            AreEqual(new[] { 2, 3, 5, 7, 11, 13, 17, 19, 23 }, algorithm.Calculate(23));
            AreEqual(new[] { 2, 3, 5, 7, 11, 13, 17, 19, 23 }, algorithm.Calculate(24));
            AreEqual(new[] { 2, 3, 5, 7, 11, 13, 17, 19, 23 }, algorithm.Calculate(25));
            AreEqual(new[] { 2, 3, 5, 7, 11, 13, 17, 19, 23 }, algorithm.Calculate(26));
            AreEqual(new[] { 2, 3, 5, 7, 11, 13, 17, 19, 23 }, algorithm.Calculate(27));
            AreEqual(new[] { 2, 3, 5, 7, 11, 13, 17, 19, 23 }, algorithm.Calculate(28));
            AreEqual(new[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 }, algorithm.Calculate(29));
            AreEqual(new[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 }, algorithm.Calculate(30));
        }

        [Test]
        public void FindsAllPrimeNumbersForHundredInputCase()
        {
            // Arrange
            var algorithm = new Sieve();

            // Act | Assert
            AreEqual(new[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61,
                67, 71, 73, 79, 83, 89, 97 }, algorithm.Calculate(100));
        }
    }
}