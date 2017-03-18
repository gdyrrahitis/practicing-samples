namespace Decorator
{
    public interface IWeapon
    {
        int Damage { get; }
        int Accuracy { get; }
        int Recoil { get; }
    }
}