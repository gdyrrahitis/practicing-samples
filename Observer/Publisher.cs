namespace Observer
{
    using System.Collections.Generic;
    using System.Linq;

    public class Publisher : IPublisher
    {
        private readonly HashSet<ISubscriber> _subscribers;

        public Publisher() : this(Enumerable.Empty<ISubscriber>()) { }

        public Publisher(IEnumerable<ISubscriber> subscribers)
        {
            _subscribers = new HashSet<ISubscriber>(subscribers);
        }

        private string _message;
        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                Notify();
            }
        }

        public HashSet<ISubscriber> Subscribers => _subscribers;

        public void Subscribe(ISubscriber subscriber)
        {
            AddSubscriberIfItIsNotNull(subscriber);
        }

        private void AddSubscriberIfItIsNotNull(ISubscriber subscriber)
        {
            if (SubscriberHasValue(subscriber))
                _subscribers.Add(subscriber);
        }

        private static bool SubscriberHasValue(ISubscriber subscriber)
        {
            return subscriber != null;
        }

        public void UnSubscribe(ISubscriber subscriber)
        {
            RemoveSubscriberIfItIsNotNull(subscriber);
        }

        private void RemoveSubscriberIfItIsNotNull(ISubscriber subscriber)
        {
            if (SubscriberHasValue(subscriber))
                _subscribers.Remove(subscriber);
        }

        public void Notify()
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.MessageChanged(Message);
            }
        }
    }
}