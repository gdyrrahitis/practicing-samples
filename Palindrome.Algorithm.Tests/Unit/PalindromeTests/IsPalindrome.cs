namespace Palindrome.Algorithm.Tests.Unit.PalindromeTests
{
    using System;
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

    [TestFixture]
    public class IsPalindrome
    {
        [Test]
        public void IsInstanceOfPalindrome()
        {
            // Arrange
            var instance = new Palindrome();

            // Act | Assert 
            IsInstanceOf<Palindrome>(instance);
        }

        [Test]
        public void ReturnsForValidPaldindromeWord()
        {
            // Arrange
            var palindrome = new Palindrome();

            // Act | Assert
            Throws<ArgumentNullException>(() => palindrome.IsPalindrome(null));
            Throws<ArgumentNullException>(() => palindrome.IsPalindrome(""));
            Throws<ArgumentException>(() => palindrome.IsPalindrome("a"));
            AreEqual(true, palindrome.IsPalindrome("aa"));
            AreEqual(true, palindrome.IsPalindrome("aaa"));
            AreEqual(false, palindrome.IsPalindrome("aaab"));
            AreEqual(true, palindrome.IsPalindrome("eye"));
            AreEqual(true, palindrome.IsPalindrome("civic"));
            AreEqual(false, palindrome.IsPalindrome("george"));
            AreEqual(true, palindrome.IsPalindrome("anna"));
        }
    }
}
