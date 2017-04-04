namespace Patterns.Command.Tests.Commands.SubtractCommandTests
{
    using Command.Commands;
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

    [TestFixture]
    public class Do
    {
        [TestCase(5, -5)]
        [TestCase(17, -17)]
        public void SubtractsNumberUsingCommandAndReturnsNegativeNumberWithPublicProperty(int number, int expected)
        {
            // Arrange
            var subtractCommand = new SubtractCommand(number);

            // Act
            subtractCommand.Do();
            var result = subtractCommand.Number;

            // Assert
            That(result, Is.EqualTo(expected));
        }
    }
}