namespace SpecialCase.Player
{
    public class IronCloak: ISpecialDefence
    {
        public int CalculateDamage(int damage)
        {
            return (int) (damage * 0.2);
        }
    }
}