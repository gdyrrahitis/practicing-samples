namespace Patterns.Iterator.Tests.V1.PersonTests
{
    using Iterator.V1;
    using NUnit.Framework;

    [TestFixture]
    public class GetIterator
    {
        [Test]
        public void ReturnsPersonIteratorWhichImplementsAbstractIterator()
        {
            // Arrange
            var person = new Person("George", "Dyrrachits", 28);

            // Act 
            var result = person.GetIterator();

            // Assert
            Assert.That(result, Is.AssignableTo<Iterator>());
            Assert.That(result, Is.TypeOf<PersonIterator>());
        }
    }
}