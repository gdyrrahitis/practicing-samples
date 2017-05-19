namespace Algorithm.ReverseInteger.Tests.Unit.ReverseIntegerTests
{
    using NUnit.Framework;

    [TestFixture]
    public class Reverse
    {
        [Test]
        public void InstanceIsDefined()
        {
            // Arrange
            var instance = new ReverseInteger();

            // Act | Assert
            Assert.IsInstanceOf<ReverseInteger>(instance);
        }

        [Test]
        public void ReversesAllIntegerInput()
        {
            // Arrange
            var reverser = new ReverseInteger();

            // Act | Assert
            Assert.AreEqual("0", reverser.Reverse(0));
            Assert.AreEqual("9", reverser.Reverse(9));
            Assert.AreEqual("01", reverser.Reverse(10));
            Assert.AreEqual("51", reverser.Reverse(15));
            Assert.AreEqual("84", reverser.Reverse(48));
            Assert.AreEqual("415", reverser.Reverse(514));
            Assert.AreEqual("4201", reverser.Reverse(1024));
        }
    }
}