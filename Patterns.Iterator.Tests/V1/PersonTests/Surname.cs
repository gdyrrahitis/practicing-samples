namespace Patterns.Iterator.Tests.V1.PersonTests
{
    using Iterator.V1;
    using NUnit.Framework;

    [TestFixture]
    public class Surname
    {
        [TestCase("George", "Dyrrachitis")]
        [TestCase("John", "Doe")]
        public void CanBeDefinedTo(string firstName, string lastName)
        {
            // Arrange
            var person = new Person(firstName, lastName, 0);

            // Act
            var result = person.Surname;

            // Assert
            Assert.That(result, Is.EqualTo(lastName));
        }
    }
}