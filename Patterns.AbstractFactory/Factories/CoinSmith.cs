namespace Patterns.AbstractFactory.Factories
{
    using Products;

    public class CoinSmith: ISmith
    {
        public Metal Forge() => new Coin();
    }
}