namespace Palindrome.Algorithm.Tests.Unit.V1.PalindromeTests
{
    using System;
    using Algorithm.V1;
    using NUnit.Framework;

    [TestFixture]
    public class IsPalindrome
    {
        [Test]
        public void IsInstanceOfPalindrome()
        {
            // Arrange
            var instance = new Palindrome();

            // Act | Assert 
            Assert.IsInstanceOf<Palindrome>(instance);
        }

        [Test]
        public void ReturnsForValidPaldindromeWord()
        {
            // Arrange
            var palindrome = new Palindrome();

            // Act | Assert
            Assert.Throws<ArgumentNullException>(() => palindrome.IsPalindrome(null));
            Assert.Throws<ArgumentNullException>(() => palindrome.IsPalindrome(""));
            Assert.Throws<ArgumentException>(() => palindrome.IsPalindrome("a"));
            Assert.AreEqual(true, palindrome.IsPalindrome("aa"));
            Assert.AreEqual(true, palindrome.IsPalindrome("aaa"));
            Assert.AreEqual(false, palindrome.IsPalindrome("aaab"));
            Assert.AreEqual(true, palindrome.IsPalindrome("eye"));
            Assert.AreEqual(true, palindrome.IsPalindrome("civic"));
            Assert.AreEqual(false, palindrome.IsPalindrome("george"));
            Assert.AreEqual(true, palindrome.IsPalindrome("anna"));
        }
    }
}
