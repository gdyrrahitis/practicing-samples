namespace Patterns.AbstractFactory.Tests.Factories.CoinSmithTests
{
    using AbstractFactory.Factories;
    using Products;
    using Xunit;
    using static Xunit.Assert;

    public class Forge
    {
        [Fact]
        public void CoinSmithForgesCoins()
        {
            // Arrange
            ISmith smith = new CoinSmith();

            // Act
            var result = smith.Forge();

            // Assert
            IsType<Coin>(result);
            IsNotType<Sword>(result);
            IsNotType<ArrowHead>(result);
        }
    }
}