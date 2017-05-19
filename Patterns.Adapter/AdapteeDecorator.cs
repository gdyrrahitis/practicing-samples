namespace Adapter
{
    public class AdapteeDecorator: Adaptee
    {
        internal new double Request(int value, string message = null)
        {
            return base.Request(value, message);
        }
    }
}