namespace Algorithm.Palindrome.Tests.Unit.V2
{
    using NUnit.Framework;
    using Palindrome.V2;

    [TestFixture]
    public class IsPalindrome
    {
        [TestCase("aha", true)]
        [TestCase("atoyota", true)]
        [TestCase("george", false)]
        [TestCase("eye", true)]
        public void Success(string value, bool expected)
        {
            // Arrange
            var palindrome = new Palindrome();

            // Act
            var result = palindrome.IsPalindrome(value);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}