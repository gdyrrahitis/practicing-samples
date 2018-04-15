namespace Algorithm.Stack.Implementations.Tests.BracketsTests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class Check
    {
        [TestCase("a(b)c[def{g}]", true)]
        [TestCase("a(c}d", false)]
        [TestCase("a(c)", true)]
        [TestCase("(c)", true)]
        [TestCase("{(c)}", true)]
        public void ShouldVerifyThatExpressionHasCorrectOpeningAndClosingDelimiters(string expression, bool isCorrect)
        {
            // Arrange
            var brackets = new Brackets(expression);

            // Act
            var result = brackets.Check();

            // Assert
            Assert.AreEqual(isCorrect, result);
        }
    }
}