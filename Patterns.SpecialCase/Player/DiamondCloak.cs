namespace SpecialCase.Player
{
    public class DiamondCloak : ISpecialDefence
    {
        public int CalculateDamage(int damage)
        {
            return damage / 2;
        }
    }
}