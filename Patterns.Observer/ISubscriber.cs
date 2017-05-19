namespace Observer
{
    public interface ISubscriber
    {
        void MessageChanged(string message);
    }
}