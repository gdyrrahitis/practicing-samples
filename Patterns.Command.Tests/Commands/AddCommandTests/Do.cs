namespace Patterns.Command.Tests.Commands.AddCommandTests
{
    using Command.Commands;
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

    [TestFixture]
    public class Do
    {
        [TestCase(5, 5)]
        [TestCase(17, 17)]
        public void AddsNumberUsingCommandAndReturnsItWithPublicProperty(int number, int expected)
        {
            // Arrange
            var addCommand = new AddCommand(number);

            // Act
            addCommand.Do();
            var result = addCommand.Number;

            // Assert
            That(result, Is.EqualTo(expected));
        }
    }
}