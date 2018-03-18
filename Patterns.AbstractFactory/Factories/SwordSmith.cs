namespace Patterns.AbstractFactory.Factories
{
    using Products;

    public class SwordSmith: ISmith
    {
        public Metal Forge() => new Sword();
    }
}