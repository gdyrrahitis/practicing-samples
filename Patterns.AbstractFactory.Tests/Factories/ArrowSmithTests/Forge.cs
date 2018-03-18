namespace Patterns.AbstractFactory.Tests.Factories.ArrowSmithTests
{
    using AbstractFactory.Factories;
    using Products;
    using Xunit;
    using static Xunit.Assert;

    public class Forge
    {
        [Fact]
        public void ArrowSmithForgesArrowHeads()
        {
            // Arrange
            ISmith smith = new ArrowSmith();

            // Act
            var result = smith.Forge();

            // Assert
            IsType<ArrowHead>(result);
            IsNotType<Sword>(result);
            IsNotType<Coin>(result);
        }
    }
}