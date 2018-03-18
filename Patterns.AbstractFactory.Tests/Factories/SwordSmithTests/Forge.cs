namespace Patterns.AbstractFactory.Tests.Factories.SwordSmithTests
{
    using AbstractFactory.Factories;
    using Products;
    using Xunit;
    using static Xunit.Assert;

    public class Forge
    {
        [Fact]
        public void SwordSmithForgesSwords()
        {
            // Arrange
            ISmith smith = new SwordSmith();

            // Act
            var result = smith.Forge();

            // Assert
            IsType<Sword>(result);
            IsNotType<Coin>(result);
            IsNotType<ArrowHead>(result);
        }
    }
}