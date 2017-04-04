namespace Patterns.Command.Tests.Commands.AddCommandTests
{
    using Command.Commands;
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

    [TestFixture]
    public class Undo
    {
        [TestCase(5, 0)]
        [TestCase(17, 0)]
        public void ResetsCommandBackToItsOriginalZeroValue(int number, int expected)
        {
            // Arrange
            var addCommand = new AddCommand(number);
            addCommand.Do();

            // Act
            addCommand.Undo();
            var result = addCommand.Number;

            // Assert
            That(result, Is.EqualTo(expected));
        }
    }
}