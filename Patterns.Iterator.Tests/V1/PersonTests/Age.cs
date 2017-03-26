namespace Patterns.Iterator.Tests.V1.PersonTests
{
    using Iterator.V1;
    using NUnit.Framework;

    [TestFixture]
    public class Age
    {
        [TestCase("George", "Dyrrachitis", 28)]
        [TestCase("John", "Doe", 40)]
        public void CanBeDefinedTo(string firstName, string lastName, int age)
        {
            // Arrange
            var person = new Person(firstName, lastName, age);

            // Act
            var result = person.Age;

            // Assert
            Assert.That(result, Is.EqualTo(age));
        }
    }
}