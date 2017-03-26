namespace Patterns.Iterator.Tests.V1.PersonTests
{
    using Iterator.V1;
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

    [TestFixture]
    public class Count
    {
        [TestCase(3)]
        public void IsCountOfObjectProperties(int count)
        {
            // Arrange
            var person = new Person("George", "Dyrrachitis", 28);

            // Act
            var result = person.Count;

            // Assert
            That(result, Is.EqualTo(count));
        }
    }
}