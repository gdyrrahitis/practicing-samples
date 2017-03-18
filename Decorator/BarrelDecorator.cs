namespace Decorator
{
    public class BarrelDecorator: WeaponDecorator
    {
        public BarrelDecorator(IWeapon weapon) : base(weapon)
        {
        }

        public override int Damage => 89;
    }
}