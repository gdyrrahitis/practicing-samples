namespace Patterns.Iterator.Tests.V1.PersonIteratorTests
{
    using Iterator.V1;
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

    [TestFixture]
    public class Get
    {
        [TestCase(0, "George")]
        [TestCase(1, "Dyrrachitis")]
        [TestCase(2, 28)]
        public void IteratesThroughPersonThreeProperties(int index, object property)
        {
            // Arrange
            var person = new Person("George", "Dyrrachitis", 28);
            var iterator = new PersonIterator(person);

            // Act
            var result = iterator.Get(index);

            // Assert
            That(result, Is.EqualTo(property));
        }
    }
}