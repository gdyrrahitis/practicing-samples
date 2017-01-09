namespace Visitor.Tests.SalariedEmployeeTests
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
            var result = new SalariedEmployee();

            // Assert
            IsInstanceOf<IEmployee>(result);
        }
    }
}