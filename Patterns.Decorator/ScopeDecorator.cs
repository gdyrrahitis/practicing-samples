namespace Patterns.Decorator
{
    public class ScopeDecorator: WeaponDecorator
    {
        public ScopeDecorator(IWeapon weapon) : base(weapon)
        {
        }

        public override int Accuracy => 90;
    }
}