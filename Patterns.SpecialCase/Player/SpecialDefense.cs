namespace SpecialCase.Player
{
    public abstract class SpecialDefense
    {
        public static SpecialDefense Null { get; } = new NullCloak();

        public abstract int CalculateDamage(int damage);

        private class NullCloak : SpecialDefense
        {
            public override int CalculateDamage(int damage) => 0;
        }
    }
}