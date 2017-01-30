namespace Palindrome.Algorithm.Tests.Unit.V2
{
    using Algorithm.V2;
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

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
            That(result, Is.EqualTo(expected));
        }
    }
}