namespace Patterns.Builder
{
    using Cyborgs;
    using Cyborgs.Deadly;

    public class Skynet
    {
        public static Cyborg MakeT800()
        {
            var builder = new CyborgBuilder(Type.T800);
            builder.BuildArms(new Arms());
            builder.BuildHead(new Head());
            builder.BuildLegs(new Legs());
            builder.BuildTorso(new Torso());
            return builder.GetCyborg();
        }

        public static Cyborg MakeTx()
        {
            var builder = new CyborgBuilder(Type.Tx);
            builder.BuildTorso(new ArmoredTorso());
            builder.BuildArms(new Arms());
            builder.BuildHead(new Head());
            builder.BuildLegs(new Legs());
            builder.BuildExtras(new FlameThrower());
            return builder.GetCyborg();
        }
    }
}