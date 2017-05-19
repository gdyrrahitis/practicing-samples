namespace Visitor.Tests.HourlyEmployeeTests
{
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

    [TestFixture]
    public class Constructor
    {
        [Test]
        public void InheritsIEmployee()
        {
            // Arrange | Act
            var result = new HourlyEmployee();

            // Assert
            IsInstanceOf<IEmployee>(result);
        }
    }
}