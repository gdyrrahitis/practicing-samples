namespace Data.Structures.Queue.Tests.QueueTests
{
    using NUnit.Framework;

    [TestFixture]
    public class Enumerate
    {
        [TestCase(new[] { 5, 6 })]
        [TestCase(new[] { 57, 94, 22, 33 })]
        public void ShouldBeAbleToEnumerateTheQueue(int[] array)
        {
            // Arrange
            var count = 0;
            var queue = new Queue();
            foreach (var value in array)
            {
                queue.Push(value);
            }

            // Act | Assert
            foreach (var item in queue)
            {
                Assert.AreEqual(array[count], item);
                count++;
            }
        }
    }
}