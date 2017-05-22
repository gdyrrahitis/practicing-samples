namespace Patterns.Decorator
{
    public class WeaponDecorator: IWeapon
    {
        private readonly IWeapon _weapon;

        public WeaponDecorator(IWeapon weapon)
        {
            _weapon = weapon;
        }

        public virtual int Damage => _weapon.Damage;
        public virtual int Accuracy => _weapon.Accuracy;
        public virtual int Recoil => _weapon.Recoil;
    }
}