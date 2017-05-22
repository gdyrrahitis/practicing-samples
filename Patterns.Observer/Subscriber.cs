namespace Patterns.Observer
{
    using System;

    public class Subscriber: ISubscriber
    {
        public void MessageChanged(string message)
        {
            Console.WriteLine(message);
        }
    }
}