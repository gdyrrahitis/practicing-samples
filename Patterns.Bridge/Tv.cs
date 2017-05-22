namespace Patterns.Bridge
{
    public class Tv: AbstractDevice
    {
        public override void On()
        {
            // Tv specific On instruction
        }

        public override void Off()
        {
            // Tv specific Off instruction
        }
    }
}