namespace ReverseInteger.Tests.Unit.ReverseIntegerTests
{
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

    [TestFixture]
    public class Reverse
    {
        [Test]
        public void InstanceIsDefined()
        {
            // Arrange
            var instance = new ReverseInteger();

            // Act | Assert
            IsInstanceOf<ReverseInteger>(instance);
        }

        [Test]
        public void ReversesAllIntegerInput()
        {
            // Arrange
            var reverser = new ReverseInteger();

            // Act | Assert
            AreEqual("0", reverser.Reverse(0));
            AreEqual("9", reverser.Reverse(9));
            AreEqual("01", reverser.Reverse(10));
            AreEqual("51", reverser.Reverse(15));
            AreEqual("84", reverser.Reverse(48));
            AreEqual("415", reverser.Reverse(514));
            AreEqual("4201", reverser.Reverse(1024));
        }
    }
}