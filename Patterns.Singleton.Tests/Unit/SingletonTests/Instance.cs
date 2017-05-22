namespace Patterns.Singleton.Tests.Unit.SingletonTests
{
    using NUnit.Framework;

    [TestFixture]
    public class Instance
    {
        [Test]
        public void SingletonPattern_IsSingleInstance_ByHavingTheSameHashCode_Test()
        {
            // Arrange | Act
            var firstInstantiation = Singleton.Instance;
            var secondInstantiation = Singleton.Instance;

            // Assert
            Assert.AreEqual(firstInstantiation.GetHashCode(), secondInstantiation.GetHashCode());
        }
    }
}