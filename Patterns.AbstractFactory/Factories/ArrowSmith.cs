namespace Patterns.AbstractFactory.Factories
{
    using Products;

    public class ArrowSmith: ISmith
    {
        public Metal Forge() => new ArrowHead();
    }
}