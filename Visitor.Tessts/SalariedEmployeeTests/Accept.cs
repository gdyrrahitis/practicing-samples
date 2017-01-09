namespace Visitor.Tests.SalariedEmployeeTests
{
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

    [TestFixture]
    public class Accept
    {
        [Test]
        public void CalculatesMonthlyRenumeration()
        {
            // Arrange
            IEmployee salariedEmployee = new SalariedEmployee();
            IEmployeeVisitor visitor = new CalculateRenumeration();

            // Act
            var result = salariedEmployee.Accept(visitor);

            // Assert
            AreEqual("renumeration", result);
        }

        [Test]
        public void CalculatesHourly()
        {
            // Arrange
            IEmployee salariedEmployee = new SalariedEmployee();
            IEmployeeVisitor visitor = new CalculateRate();

            // Act
            var result = salariedEmployee.Accept(visitor);

            // Assert
            AreEqual("rate", result);
        }
    }
}