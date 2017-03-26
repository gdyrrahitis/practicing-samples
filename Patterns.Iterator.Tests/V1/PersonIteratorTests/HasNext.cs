namespace Patterns.Iterator.Tests.V1.PersonIteratorTests
{
    using Iterator.V1;
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

    [TestFixture]
    public class HasNext
    {
        [Test]
        public void WhenNullReturnsFalse()
        {
            // Arrange
            var iterator = new PersonIterator(null);            

            // Act
            var result = iterator.HasNext();

            // Assert
            That(result, Is.EqualTo(false));
        }

        [Test]
        public void WhenOutOfIndexReturnsFalse()
        {
            // Arrange
            var person = new Person("George", "Dyrrachitis", 28);
            var iterator = new PersonIterator(person);

            // Act
            var result = GetResultAfterFourLoops(iterator);

            // Assert
            That(result, Is.EqualTo(false));
        }

        private static bool GetResultAfterFourLoops(Iterator iterator)
        {
            for (var i = 0; i < 3; i++)
            {
                iterator.HasNext();
            }

            var result = iterator.HasNext();
            return result;
        }
    }
}