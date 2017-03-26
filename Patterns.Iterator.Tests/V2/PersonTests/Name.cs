namespace Patterns.Iterator.Tests.V2.PersonTests
{
    using Iterator.V2;
    using NUnit.Framework;

    [TestFixture]
    public class Name
    {
        [TestCase("George")]
        [TestCase("John")]
        public void CanBeDefinedTo(string name)
        {
            // Arrange
            var person = new Person(name, string.Empty, 0);

            // Act
            var result = person.Name;

            // Assert
            Assert.That(result, Is.EqualTo(name));
        }
    }
}