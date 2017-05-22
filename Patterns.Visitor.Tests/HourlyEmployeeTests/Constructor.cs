namespace Patterns.Visitor.Tests.HourlyEmployeeTests
{
    using NUnit.Framework;

    [TestFixture]
    public class Constructor
    {
        [Test]
        public void InheritsIEmployee()
        {
            // Arrange | Act
            var result = new HourlyEmployee();

            // Assert
            Assert.IsInstanceOf<IEmployee>(result);
        }
    }
}