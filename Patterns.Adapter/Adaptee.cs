namespace Adapter
{
    public class Adaptee
    {
        public double Request(int value, string message = null)
        {
            return (double)value / 3;
        }
    }
}