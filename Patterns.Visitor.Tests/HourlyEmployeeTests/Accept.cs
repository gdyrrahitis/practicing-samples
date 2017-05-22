namespace Patterns.Visitor.Tests.HourlyEmployeeTests
{
    using NUnit.Framework;

    [TestFixture]
    public class Accept
    {
        [Test]
        public void CalculatesMonthlyRenumeration()
        {
            // Arrange
            IEmployee salariedEmployee = new HourlyEmployee();
            IEmployeeVisitor visitor = new CalculateRenumeration();

            // Act
            var result = salariedEmployee.Accept(visitor);

            // Assert
            Assert.AreEqual("renumeration", result);
        }

        [Test]
        public void CalculatesHourly()
        {
            // Arrange
            IEmployee salariedEmployee = new HourlyEmployee();
            IEmployeeVisitor visitor = new CalculateRate();

            // Act
            var result = salariedEmployee.Accept(visitor);

            // Assert
            Assert.AreEqual("rate", result);
        }
    }
}