namespace Patterns.Iterator.V1
{
    public class PersonIterator: Iterator
    {
        private readonly Person _person;
        private int _current = 0;

        public PersonIterator(Person person)
        {
            _person = person;
        }

        public override bool HasNext()
        {
            return _person != null && ++_current <= _person.Count;
        }

        public override object Get(int index)
        {
            return _person[index];
        }
    }
}