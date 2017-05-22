namespace Patterns.Memento
{
    using System.Collections.Generic;

    public class Memento
    {
        private IDictionary<string, Shape> _state;
        public IDictionary<string, Shape> State
        {
            get { return _state; }
            set
            {
                _state = new Dictionary<string, Shape>();
                foreach (var shape in value)
                    _state.Add(shape);
            }
        }
    }
}
