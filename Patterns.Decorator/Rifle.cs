namespace Patterns.Decorator
{
    public class Rifle : IWeapon
    {
        public virtual int Damage => 70;
        public virtual int Accuracy => 65;
        public virtual int Recoil => 48;
    }
}