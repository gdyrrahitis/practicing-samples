namespace SpecialCase.Player
{
    public class NullCloak : ISpecialDefence
    {
        public int CalculateDamage(int damage) => 0;
    }
}