namespace Patterns.Visitor.Tests.SalariedEmployeeTests
{
    using NUnit.Framework;

    [TestFixture]
    public class Constructor
    {
        [Test]
        public void InheritsIEmployee()
        {
            // Arrange | Act
            var result = new SalariedEmployee();

            // Assert
            Assert.IsInstanceOf<IEmployee>(result);
        }
    }
}