namespace Patterns.Bridge
{
    public class Switch: AbstractSwitch
    {
        public override AbstractDevice Device { get; set; }

        public override void On()
        {
            Device.On();
        }

        public override void Off()
        {
            Device.Off();
        }
    }
}