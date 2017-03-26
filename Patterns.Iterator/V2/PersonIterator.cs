namespace Patterns.Iterator.V2
{
    using System.Collections;
    using System.Collections.Generic;

    public class PersonIterator : IEnumerable
    {
        private readonly List<object> _list;

        public PersonIterator(Person person)
        {
            _list = new List<object> { person.Name, person.Surname, person.Age };
        }

        public IEnumerator GetEnumerator()
        {
            return _list.GetEnumerator();
        }
    }
}