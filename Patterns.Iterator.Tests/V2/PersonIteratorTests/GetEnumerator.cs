namespace Patterns.Iterator.Tests.V2.PersonIteratorTests
{
    using System.Collections;
    using Iterator.V2;
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

    [TestFixture]
    public class GetEnumerator
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
            var result = GetObjectOnIndexFromIterator(index, iterator);

            // Assert
            That(result, Is.EqualTo(property));
        }

        private object GetObjectOnIndexFromIterator(int index, IEnumerable iterator)
        {
            var count = 0;
            object result = null;
            foreach (var item in iterator)
            {
                if (count++ == index)
                {
                    result = item;
                }
            }
            return result;
        }
    }
}