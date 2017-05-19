namespace Decorator
{
    public class RecoilPadDecorator: WeaponDecorator
    {
        public RecoilPadDecorator(IWeapon weapon) : base(weapon)
        {
        }

        public override int Recoil => 71;
    }
}