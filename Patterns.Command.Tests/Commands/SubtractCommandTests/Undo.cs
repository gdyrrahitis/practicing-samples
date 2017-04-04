namespace Patterns.Command.Tests.Commands.SubtractCommandTests
{
    using Command.Commands;
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

    [TestFixture]
    public class Undo
    {
        [TestCase(5, 0)]
        [TestCase(17, 0)]
        public void SubtractsNumberAndUndoesOperationResultingInBaseZeroValue(int number, int expected)
        {
            // Arrange
            var subtractCommand = new SubtractCommand(number);
            subtractCommand.Do();

            // Act
            subtractCommand.Undo();
            var result = subtractCommand.Number;

            // Assert
            That(result, Is.EqualTo(expected));
        }
    }
}