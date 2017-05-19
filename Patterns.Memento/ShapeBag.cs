namespace Memento
{
    using System.Collections.Generic;

    public class ShapeBag
    {
        private IDictionary<string, Shape> _shapes;

        public ShapeBag()
        {
            _shapes = new Dictionary<string, Shape>();
        }

        public void AddShape(string name, Shape shape)
        {
            _shapes.Add(name, shape);
        }

        public IDictionary<string, Shape> GetShapes()
        {
            return _shapes;
        }

        public Shape GetShape(string name)
        {
            return _shapes[name];
        }

        public void RemoveShape(string name)
        {
            _shapes.Remove(name);
        }

        public Memento CreateMemento()
        {
            return new Memento
            {
                State = _shapes
            };
        }

        public void RestoreMemento(Memento memento)
        {
            _shapes = memento.State;
        }
    }
}
