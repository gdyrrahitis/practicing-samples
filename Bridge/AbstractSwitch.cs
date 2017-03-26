namespace Bridge
{
    public abstract class AbstractSwitch
    {
        public abstract AbstractDevice Device { get; set; }
        public abstract void On();
        public abstract void Off();
    }
}