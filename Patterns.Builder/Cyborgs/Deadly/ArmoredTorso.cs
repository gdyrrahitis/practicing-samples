namespace Patterns.Builder.Cyborgs.Deadly
{
    public class ArmoredTorso : ArmoredPart
    {
        public override int Power() => 100 * Armor();

        public override int Armor() => 5;
    }
}