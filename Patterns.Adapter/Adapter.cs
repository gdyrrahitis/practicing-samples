namespace Adapter
{
    public class Adapter: AdapteeDecorator, ITarget
    {
        public int Request(int value)
        {
            var oldResult = base.Request(value);

            return (int) oldResult;
        }
    }
}