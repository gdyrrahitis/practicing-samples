namespace Visitor.Tests.CalculateRateTests
{
    using Visitor;
    using NUnit.Framework;

    [TestFixture]
    public class Constructor
    {
        [Test]
        public void ImplementsIEmployeeVisitor()
        {
            // Arrange | Act
            var result = new CalculateRate();

            // Assert
            Assert.IsInstanceOf<IEmployeeVisitor>(result);
        }
    }
}