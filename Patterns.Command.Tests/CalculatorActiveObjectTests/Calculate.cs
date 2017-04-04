namespace Patterns.Command.Tests.CalculatorActiveObjectTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Command.Commands;
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

    [TestFixture]
    public class Calculate
    {
        [TestCase(new[] { 5, 1 }, new[] { typeof(AddCommand), typeof(AddCommand) }, 6)]
        [TestCase(new[] { 5, 1, 9 }, new[] { typeof(AddCommand), typeof(AddCommand), typeof(AddCommand) }, 15)]
        public void AdditionUsingAddCommandOnlyResultingInDesignatedExpectedValue(int[] numbers, Type[] types, int expected)
        {
            // Arrange
            var calculatorActiveObject = new CalculatorActiveObject();
            PushCommandsToActiveObject(numbers, types, calculatorActiveObject);

            // Act
            var result = calculatorActiveObject.Calculate();

            // Assert
            That(result, Is.EqualTo(expected));
        }

        private void PushCommandsToActiveObject(IReadOnlyList<int> numbers, IReadOnlyList<Type> types,
            CalculatorActiveObject activeObject)
        {
            for (var i = 0; i < numbers.Count; i++)
            {
                var type = types[i];
                var command = (ICommand)Activator.CreateInstance(type, numbers[i]);
                activeObject.Push(command);
            }
        }

        [TestCase(new[] { 5, 1 }, new[] { typeof(SubtractCommand), typeof(SubtractCommand) }, -6)]
        [TestCase(new[] { 5, 1, 9 }, new[] { typeof(SubtractCommand), typeof(SubtractCommand), typeof(SubtractCommand) }, -15)]
        public void SubtractUsingSubtractCommandOnlyResultingInDesignatedExpectedValue(int[] numbers, Type[] types, int expected)
        {
            // Arrange
            var calculatorActiveObject = new CalculatorActiveObject();
            PushCommandsToActiveObject(numbers, types, calculatorActiveObject);

            // Act
            var result = calculatorActiveObject.Calculate();

            // Assert
            That(result, Is.EqualTo(expected));
        }


        [TestCase(new[] { 88, 40 }, new[] { typeof(AddCommand), typeof(SubtractCommand) }, 48)]
        [TestCase(new[] { 50, 50, 20 }, new[] { typeof(AddCommand), typeof(AddCommand), typeof(SubtractCommand) }, 80)]
        public void MixingAddAndSubtractCommandsResultingInDesignatedExpectedValue(int[] numbers, Type[] types, int expected)
        {
            // Arrange
            var calculatorActiveObject = new CalculatorActiveObject();
            PushCommandsToActiveObject(numbers, types, calculatorActiveObject);

            // Act
            var result = calculatorActiveObject.Calculate();

            // Assert
            That(result, Is.EqualTo(expected));
        }

        [TestCase(new[] { 88, 40 }, new[] { typeof(AddCommand), typeof(SubtractCommand) }, -40)]
        [TestCase(new[] { 50, 50, 20 }, new[] { typeof(AddCommand), typeof(AddCommand), typeof(SubtractCommand) }, 30)]
        public void MixingAddAndSubtractCommandsAndUndoingOperationAfterFirstCommandResultingInDesignatedExpectedValue(
            int[] numbers, Type[] types, int expected)
        {
            // Arrange
            var calculatorActiveObject = new CalculatorActiveObject();
            PushCommandsToActiveObject(numbers.Take(1).ToArray(), types.Take(1).ToArray(), calculatorActiveObject);
            PopCommandFromActiveObject(calculatorActiveObject);
            PushCommandsToActiveObject(numbers.Skip(1).ToArray(), types.Skip(1).ToArray(), calculatorActiveObject);

            // Act
            var result = calculatorActiveObject.Calculate();

            // Assert
            That(result, Is.EqualTo(expected));
        }

        private void PopCommandFromActiveObject(CalculatorActiveObject calculatorActiveObject)
        {
            calculatorActiveObject.Pop();
        }
    }
}