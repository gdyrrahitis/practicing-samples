namespace SpecialCase.Player
{
    public class Character
    {
        private readonly ISpecialDefence _specialDefence;
        private static int _health = 100;

        public Character(ISpecialDefence specialDefence)
        {
            _specialDefence = specialDefence;
        }

        public int HealthReduceByDamage(int damage)
        {
            damage = CalculateDamageWithDefense(damage);
            return _health - damage;
        }

        private int CalculateDamageWithDefense(int damage)
        {
            damage -= _specialDefence.CalculateDamage(damage);
            return damage;
        }
    }
}