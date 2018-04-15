namespace Algorithm.Stack.Implementations.Tests.ReverserTests
{
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

    [TestFixture]
    public class Reverse
    {
        [TestCase("car", "rac")]
        [TestCase("george", "egroeg")]
        [TestCase("part", "trap")]
        public void ShouldReverseWordToExpected(string input, string expected)
        {
            // Arrange
            var reverser = new Reverser(input);

            // Act
            var result = reverser.Reverse();

            // Assert
            AreEqual(expected, result);
        }
    }
}