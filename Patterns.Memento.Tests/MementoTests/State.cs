namespace Patterns.Memento.Tests.MementoTests
{
    using System.Collections.Generic;
    using System.Linq;
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

    [TestFixture]
    public class State
    {
        [Test]
        public void InitialStateIsNull()
        {
            // Arrange
            var memento = new Memento();

            // Act
            var result = memento.State;

            // Assert
            IsNull(result);
        }

        [Test]
        public void ReturnsOneItemAfterAssigningDictionaryToState()
        {
            // Arrange
            var memento = new Memento
            {
                State = new Dictionary<string, Shape> { { "triangle", new Triangle() } }
            };

            // Act
            var result = memento.State;

            // Assert
            AreEqual(1, result.Count);
            AreEqual("triangle", result.First().Key);
            IsInstanceOf<Triangle>(result.First().Value);
        }
    }
}